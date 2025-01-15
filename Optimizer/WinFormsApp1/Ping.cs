using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Ping : Form
    {
        public Ping()
        {
            InitializeComponent();
        }

        private void Ping_Load(object sender, EventArgs e)
        {
            // Inicializa os valores padrão
            lblMtu.Text = "1500";
            trkMtu.Value = 1500;
            cboConectionType.SelectedIndex = -1; // Sem seleção inicial
        }

        private void trkMtu_Scroll(object sender, EventArgs e)
        {
            lblMtu.Text = trkMtu.Value.ToString();
        }

        private void btnDefaultMtu_Click(object sender, EventArgs e)
        {
            lblMtu.Text = 1500.ToString();
            trkMtu.Value = 1500;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblMtu.Text = 1450.ToString();
            trkMtu.Value = 1450;
        }

        private async void btnApplyPing_Click(object sender, EventArgs e)
        {
            using (LoadingForm loadingForm = new LoadingForm())
            {
                // Exibe o LoadingForm enquanto o processo está em andamento
                loadingForm.Show();

                try
                {
                    await Task.Delay(1000);
                    // Verifica se uma conexão foi selecionada
                    if (cboConectionType.SelectedIndex == -1)
                    {
                        // Mostra a página para selecionar opções
                        SelectOptions selectOptionsForm = new SelectOptions();
                        selectOptionsForm.ShowDialog();
                        return;
                    }

                    // Obtém os valores selecionados
                    string connectionType = cboConectionType.SelectedItem.ToString();
                    int mtuValue = trkMtu.Value;

                    // Valida o MTU
                    if (mtuValue < 576 || mtuValue > 1500)
                    {
                        // Mostra a página de erro
                        ErrorMessage errorMessageForm = new ErrorMessage("Valor de MTU inválido");
                        errorMessageForm.ShowDialog();
                        return;
                    }

                    // Chama o método assíncrono para aplicar a configuração de MTU
                    bool configurationApplied = await Task.Run(() => ApplyMtuConfiguration(connectionType, mtuValue));

                    if (configurationApplied)
                    {
                        // Mostra a página de sucesso
                        SucefullForm successForm = new SucefullForm();
                        successForm.ShowDialog();
                    }
                    else
                    {
                        // Mostra a página de erro em caso de falha
                        ErrorMessage errorMessageForm = new ErrorMessage("Erro ao aplicar a configuração. Verifique o tipo de conexão.");
                        errorMessageForm.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    // Exibe um erro genérico se algo der errado
                    ErrorMessage errorMessageForm = new ErrorMessage($"Erro inesperado: {ex.Message}");
                    errorMessageForm.ShowDialog();
                    Console.WriteLine($"Erro ao aplicar configuração de MTU: {ex.Message}");
                }
                finally
                {
                    // Fecha o LoadingForm ao final
                    loadingForm.Close();
                }
            }
        }

        private bool ApplyMtuConfiguration(string connectionType, int mtuValue)
        {

            try
            {
                // Determina o nome da interface com base no tipo de conexão
                string interfaceName = connectionType == "Cabble" ? "Ethernet" : "Wi-Fi";

                // Monta o comando para alterar o MTU
                string arguments = $"interface ipv4 set subinterface \"{interfaceName}\" mtu={mtuValue} store=persistent";

                // Executa o comando netsh
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = "netsh";
                process.StartInfo.Arguments = arguments;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;
                process.Start();

                // Captura a saída e erros do comando
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();

                if (process.ExitCode == 0)
                {
                    Console.WriteLine($"Comando executado com sucesso: {output}");
                    return true;
                }
                else
                {
                    Console.WriteLine($"Erro ao executar o comando: {error}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao aplicar configuração de MTU: {ex.Message}");
                return false;
            }
        }

        private async void btnFlushDns_Click(object sender, EventArgs e)
        {

            using (LoadingForm loadingForm = new LoadingForm())
            {
                loadingForm.Show();

                try
                {
                    await Task.Delay(1000);
                    await Task.Run(() =>
                    {
                        // Simula uma tarefa demorada (substitua pela sua lógica real)
                        System.Threading.Thread.Sleep(1000);
                        ExecuteCommand("ipconfig /flushdns");
                        ExecuteCommand("ipconfig /release");
                        ExecuteCommand("ipconfig /renew");
                    });

                    // Exibe mensagem de sucesso ao usuário
                    SucefullForm f = new SucefullForm();
                    f.ShowDialog();
                }
                catch (Exception ex)
                {
                    // Exibe mensagem de erro ao usuário
                    ErrorMessage f = new ErrorMessage(ex.Message);
                    f.ShowDialog();
                }
                finally
                {
                    // Fecha o LoadingForm automaticamente
                    loadingForm.Close();
                }
            }
        }

        private void ExecuteCommand(string command)
        {
            // Configura o processo para executar o comando
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"/C {command}"; // /C executa e fecha o terminal
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true; // Executa sem exibir a janela do terminal

            // Inicia o processo
            process.Start();

            // Aguarda a execução e captura a saída e erros
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();
            process.WaitForExit();

            // Exibe mensagens no console para depuração (opcional)
            Console.WriteLine($"Saída do comando: {output}");
            if (!string.IsNullOrEmpty(error))
            {
                Console.WriteLine($"Erro do comando: {error}");
            }

            // Verifica o código de saída para identificar falhas
            if (process.ExitCode != 0)
            {
                throw new Exception($"Erro ao executar o comando '{command}'. Código de saída: {process.ExitCode}");
            }
        }

        private async void btnSeachDns_Click(object sender, EventArgs e)
        {
            // Cria e exibe o LoadingForm
            using (LoadingForm loadingForm = new LoadingForm())
            {
                loadingForm.Show();

                try
                {
                    await Task.Delay(1000);
                    // Interfaces de rede para configurar DNS
                    string[] interfaces = { "Ethernet", "Wi-Fi" };
                    StringBuilder dnsSummary = new StringBuilder();
                    bool success = false;

                    // Executa a tarefa em segundo plano
                    await Task.Run(() =>
                    {
                        foreach (string interfaceName in interfaces)
                        {
                            try
                            {
                                // Verifica se a interface está disponível
                                if (IsInterfaceAvailable(interfaceName))
                                {
                                    // Configura o DNS preferencial e alternativo
                                    ConfigureBestDns(interfaceName, "8.8.8.8", "8.8.4.4");
                                    dnsSummary.AppendLine($"Google Public DNS: 8 . 8  . 8 . 8  -  8 . 8 . 4 . 4 APPLIED");
                                    success = true;
                                }
                                else
                                {
                                    dnsSummary.AppendLine($"Interface: {interfaceName} Não disponível ou desativada.");
                                }
                            }
                            catch (Exception ex)
                            {
                                // Erro específico para cada interface
                                dnsSummary.AppendLine($"Erro na interface {interfaceName}: {ex.Message}");
                                Console.WriteLine($"Erro ao configurar DNS para a interface '{interfaceName}': {ex.Message}");
                            }
                        }
                    });

                    // Atualiza o lblDns com o resumo das configurações
                    lblDns.Text = dnsSummary.ToString();

                    // Exibe mensagem apropriada com base no sucesso
                    if (success)
                    {
                        SucefullForm successForm = new SucefullForm();
                        successForm.ShowDialog();
                    }
                    else
                    {
                        throw new Exception("Não foi possível configurar DNS para nenhuma interface. Verifique as configurações de rede.");
                    }
                }
                catch (Exception ex)
                {
                    // Exibe a mensagem de erro em um formulário de erro
                    ErrorMessage errorForm = new ErrorMessage(ex.Message);
                    errorForm.ShowDialog();
                    Console.WriteLine($"Erro geral ao configurar DNS: {ex.Message}");
                }
                finally
                {
                    // Fecha o LoadingForm automaticamente
                    loadingForm.Close();
                }
            }
        }

        private bool IsInterfaceAvailable(string interfaceName)
        {
            try
            {
                // Verifica se a interface existe no sistema
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = $"/C netsh interface show interface | findstr \"{interfaceName}\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                // Retorna true se a interface for encontrada
                return !string.IsNullOrEmpty(output);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao verificar interface '{interfaceName}': {ex.Message}");
                return false;
            }
        }

        private void ConfigureBestDns(string interfaceName, string primaryDns, string secondaryDns)
        {
            try
            {
                // Valida se a interface está disponível
                if (!IsInterfaceAvailable(interfaceName))
                {
                    throw new Exception($"A interface '{interfaceName}' não foi encontrada ou está desativada.");
                }

                // Configura o DNS preferencial (primário)
                ExecuteCommand($"netsh interface ip set dns \"{interfaceName}\" static {primaryDns}");
                Console.WriteLine($"DNS preferencial configurado para '{interfaceName}': {primaryDns}");

                // Configura o DNS alternativo (secundário)
                ExecuteCommand($"netsh interface ip add dns \"{interfaceName}\" {secondaryDns} index=2");
                Console.WriteLine($"DNS alternativo configurado para '{interfaceName}': {secondaryDns}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Falha ao configurar DNS para a interface '{interfaceName}': {ex.Message}");
            }
        }

    }
}
