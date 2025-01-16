using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;


namespace WinFormsApp1
{
    public partial class Fps : Form
    {
        bool sucess = false;
        public Fps()
        {
            InitializeComponent();
        }

        private void cboWindows_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboWindows.SelectedIndex >= 0)
            {
                label2.Text = string.Empty;
            }
        }

        private async void btnApply_Click(object sender, EventArgs e)
        {

            // Verificar se nenhuma opção foi selecionada
            if (chkboxEnergy?.Checked == false && chkboxWindows?.Checked == false &&
                chkboxTemporaryFiles?.Checked == false && string.IsNullOrWhiteSpace(txtRam.Text))
            {
                // Mostrar formulário informando que é necessário selecionar opções
                ShowErrorMessage("SELECT OPTIONS!");
                return; // Sair do método, pois não há configurações para aplicar
            }

            using (LoadingForm loadingForm = new LoadingForm())
            {
                // Exibe o LoadingForm enquanto o processo está em andamento
                loadingForm.Show();
                try
                {
                    await Task.Delay(1000);

                    // Verifique se o CheckBox está disponível antes de acessar
                    if (chkboxTemporaryFiles?.Checked == true)
                    {
                        ClearTemporaryFiles();
                    }

                    if (chkboxEnergy?.Checked == true)
                    {
                        SetHighPerformancePowerPlan();
                    }

                    if (chkboxWindows?.Checked == true)
                    {
                        OptimizeWindowsSettings();
                    }
                    // Configurar memória virtual se o campo txtRam estiver preenchido
                    if (!string.IsNullOrWhiteSpace(txtRam.Text))
                    {
                        ConfigureVirtualMemory(txtRam.Text);
                    }
                }
                catch (Exception ex)
                {
                    ShowErrorMessage(ex.Message);
                }
                finally
                {
                    // Fecha o LoadingForm ao final
                    loadingForm.Close();
                }
                if (sucess)
                {
                    ShowSuccessMessage("Success!");
                }
            }
        }

        private void ClearTemporaryFiles()
        {
            try
            {
                // Diretórios de arquivos temporários
                string userTemp = Environment.GetEnvironmentVariable("TEMP"); // Temp do usuário
                string systemTemp = Path.Combine(Environment.GetEnvironmentVariable("WINDIR"), "Temp"); // Temp do sistema
                string prefetchPath = Path.Combine(Environment.GetEnvironmentVariable("WINDIR"), "Prefetch"); // Pasta Prefetch

                // Limpar arquivos do TEMP do usuário
                ClearFilesAndDirectories(userTemp);

                // Limpar arquivos do TEMP do sistema
                ClearFilesAndDirectories(systemTemp);

                ClearFilesAndDirectories(prefetchPath);

            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void ClearFilesAndDirectories(string path)
        {
            try
            {
                // Limpar arquivos
                var files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    try
                    {
                        File.Delete(file);
                    }
                    catch (IOException)
                    {
                        // Ignorar arquivos em uso
                    }
                    catch (UnauthorizedAccessException)
                    {
                        // Ignorar arquivos protegidos
                    }
                }

                // Limpar diretórios
                var directories = Directory.GetDirectories(path);
                foreach (string directory in directories)
                {
                    try
                    {
                        Directory.Delete(directory, true); // Deleta recursivamente
                    }
                    catch (IOException)
                    {
                        // Ignorar diretórios em uso
                    }
                    catch (UnauthorizedAccessException)
                    {
                        // Ignorar diretórios protegidos
                    }
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void SetHighPerformancePowerPlan()
        {
            try
            {
                Process.Start("powercfg.exe", "/setactive SCHEME_MIN");
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void OptimizeWindowsSettings()
        {
            try
            {
                // Desativar animações visuais e ajustar configurações de desempenho diretamente via registro
                OptimizeVisualEffects();

                // Desabilitar serviços desnecessários
                DisableUnnecessaryServices();

                // Ajustar o comportamento do sistema sem abrir a janela de configurações
                ConfigureSystemBehavior();

            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void OptimizeVisualEffects()
        {
            try
            {
                // Desabilitar animações visuais via registro
                Process.Start("reg", @"add HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects /v VisualFXSetting /t REG_DWORD /d 2 /f");

                // Ajustar opções de desempenho para "Melhor desempenho"
                Process.Start("reg", @"add HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced /v ListviewAlphaSelect /t REG_DWORD /d 0 /f");
                Process.Start("reg", @"add HKCU\Control Panel\Desktop /v FontSmoothing /t REG_SZ /d 0 /f");
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void DisableUnnecessaryServices()
        {
            try
            {
                // Lista de serviços desnecessários para desabilitar
                string[] servicesToDisable =
                {
                "DiagTrack", // Serviço de rastreamento de diagnóstico
                "SysMain",   // Superfetch
                "WSearch",   // Windows Search
                "Spooler"    // Serviço de impressão (se não necessário)
        };

                foreach (string service in servicesToDisable)
                {
                    Process.Start("sc", $"config {service} start= disabled");
                    Process.Start("sc", $"stop {service}");
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void ConfigureSystemBehavior()
        {
            try
            {
                // Ajustar a prioridade do tempo de resposta para aplicativos em primeiro plano
                Process.Start("reg", @"add HKLM\SYSTEM\CurrentControlSet\Control\PriorityControl /v Win32PrioritySeparation /t REG_DWORD /d 26 /f");

                // Habilitar o modo de desempenho máximo
                Process.Start("powercfg", "/setactive SCHEME_MIN");

                // Reduzir o tempo de espera ao desligar
                Process.Start("reg", @"add HKLM\SYSTEM\CurrentControlSet\Control /v WaitToKillServiceTimeout /t REG_SZ /d 2000 /f");
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }


        private void ConfigureVirtualMemory(string ramValue)
        {
            try
            {
                // Verificar se o valor no txtRam é válido
                if (!int.TryParse(ramValue, out int userRam))
                {
                    ShowErrorMessage("Invalid Value, please enter integers.");
                    return;
                }

                // Obter a memória RAM instalada no dispositivo
                int installedRam = GetInstalledRam();

                // Comparar o valor inserido com a RAM instalada
                if (userRam != installedRam)
                {
                    sucess = false;
                    ShowErrorMessage("RAM does not match installed RAM.");
                    return;
                }
                int minSize = installedRam * 1024; // Em MB
                int maxSize = (int)(minSize * 1.5); // Em MB

                if (installedRam * 1024 > 16 * 1024)
                {
                    minSize = 16 * 1024;
                    maxSize = 20 * 1024;
                }

                string disableCommand = "wmic computersystem where name=\"%computername%\" set AutomaticManagedPagefile=False";
                var disableProcess = Process.Start("cmd.exe", "/c " + disableCommand);
                disableProcess.WaitForExit();

                // Configurar memória virtual
                string configureCommand = $"wmic pagefileset where name=\"C:\\\\pagefile.sys\" set InitialSize={minSize},MaximumSize={maxSize}";
                var configureProcess = Process.Start("cmd.exe", "/c " + configureCommand);
                configureProcess.WaitForExit();

                ShowSuccessMessage("Restart your PC to take effect");
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private int GetInstalledRam()
        {
            try
            {
                // Usar o WMI para obter a RAM instalada
                var searcher = new System.Management.ManagementObjectSearcher("SELECT Capacity FROM Win32_PhysicalMemory");
                long totalCapacity = 0;

                foreach (var obj in searcher.Get())
                {
                    totalCapacity += Convert.ToInt64(obj["Capacity"]);
                }

                // Converter bytes para GB
                return (int)(totalCapacity / (1024 * 1024 * 1024));
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
                return 0;
            }
        }

        private void ShowErrorMessage(string erro)
        {
            ErrorMessage error = new ErrorMessage(erro);
            error.ShowDialog();
        }

        private void ShowSuccessMessage(string message)
        {
            SucefullForm sucess = new SucefullForm(message);
            sucess.ShowDialog();
        }
        private void txtRam_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas números (dígitos) e a tecla de controle "Backspace"
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Impede a entrada do caractere inválido
            }
        }
    }
}
