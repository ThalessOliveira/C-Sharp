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

namespace WinFormsApp1
{
    public partial class Fps : Form
    {
        public Fps()
        {
            InitializeComponent();
        }

        private void ConfigureComponents()
        {
            // Configurar o ComboBox de RAM
            cboRam.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8+" });
            cboRam.SelectedIndex = 3; // Selecionar "4 GB" como padrão

            // Configurar o ComboBox de Windows
            cboWindows.Items.Add("Windows 10");
            cboWindows.SelectedIndex = 0; // Selecionar Windows 10 como padrão

            // Adicionar evento ao botão de aplicar
            btnApply.Click += btnApply_Click;
        }

        private void cboRam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRam.SelectedIndex >= 0)
            {
                label1.Text = string.Empty;
            }
        }

        private void cboWindows_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboWindows.SelectedIndex >= 0)
            {
                label2.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar se nenhuma opção foi selecionada
                if (chkboxEnergy?.Checked == false && chkboxWindows?.Checked == false &&
                    chkboxTemporaryFiles?.Checked == false && cboRam.SelectedIndex < 0)
                {
                    // Mostrar formulário informando que é necessário selecionar opções
                    SelectOptions f = new SelectOptions();
                    f.ShowDialog();
                    return; // Sair do método, pois não há configurações para aplicar
                }

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
                ShowSuccessMessage();
            }
            catch (Exception ex)
            {
                ShowErrorMessage();
            }
        }

        private void ClearTemporaryFiles()
        {
            try
            {
                // Diretórios de arquivos temporários
                string userTemp = Environment.GetEnvironmentVariable("TEMP"); // Temp do usuário
                string systemTemp = Path.Combine(Environment.GetEnvironmentVariable("WINDIR"), "Temp"); // Temp do sistema

                // Limpar arquivos do TEMP do usuário
                ClearFilesAndDirectories(userTemp);

                // Limpar arquivos do TEMP do sistema
                ClearFilesAndDirectories(systemTemp);

                ShowSuccessMessage();
            }
            catch (Exception ex)
            {
                ShowErrorMessage();
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
                ShowErrorMessage();
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
                ShowErrorMessage();
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

                ShowSuccessMessage();
            }
            catch (Exception ex)
            {
                ShowErrorMessage();
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
                ShowErrorMessage();
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
                ShowErrorMessage();
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
                ShowErrorMessage();
            }
        }


        private void ConfigureVirtualMemory(string ramValue)
        {
            try
            {
                int ramSize = ramValue == "8+" ? 8 : int.Parse(ramValue);
                int minSize = ramSize * 1024; // Tamanho mínimo em MB
                int maxSize = ramSize * 1024 * 2; // Tamanho máximo em MB

                string command = $"wmic pagefile set /? InitialSize={minSize} /MaxSize={maxSize}";
                Process.Start("cmd.exe", "/c " + command);
            }
            catch (Exception ex)
            {
                ShowErrorMessage();
            }
        }

        private void ShowErrorMessage()
        {
            ErrorMessage error = new ErrorMessage();
            error.ShowDialog();
        }

        private void ShowSuccessMessage()
        {
            SucefullForm sucess = new SucefullForm();
            sucess.ShowDialog();
        }
    }
}
