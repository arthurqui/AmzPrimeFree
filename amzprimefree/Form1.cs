using NixPDC;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Interactions;
using Keys = OpenQA.Selenium.Keys;


namespace botmap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btn_iniciar_Click(object sender, EventArgs e)
        {

            //script para criar string aleatória
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var aleatorio = new String(stringChars);
            //FIM do script para criar string aleatória

            
            //Entra no google 
            IWebDriver driver = SeleniumMetodos.criaDriver(Constantes.headless);
            SeleniumMetodos.navegarPara(driver, "https://www.amazon.com.br/ap/register?showRememberMe=true&openid.pape.max_auth_age=3600&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&language=pt_BR&pageId=amzn_gaming_prime&ignoreAuthState=1&openid.return_to=https%3A%2F%2Fgaming.amazon.com.br%2Fprime%2Fusamazonlogin%2Fbr%3Fconfirm%3DALWAYS%26returnUri%3Dhttps%253A%252F%252Famazon.com%252Fap%252Fsignin%253Fopenid.pape.max_auth_age%253D3600%2526openid.return_to%253Dhttps%25253A%25252F%25252Fgaming.amazon.com%25252F%25253FsignedIn%25253Dtrue%2526openid.identity%253Dhttp%25253A%25252F%25252Fspecs.openid.net%25252Fauth%25252F2.0%25252Fidentifier_select%2526openid.assoc_handle%253Damzn_respawn_desktop_us%2526openid.mode%253Dcheckid_setup%2526openid.claimed_id%253Dhttp%25253A%25252F%25252Fspecs.openid.net%25252Fauth%25252F2.0%25252Fidentifier_select%2526openid.ns%253Dhttp%25253A%25252F%25252Fspecs.openid.net%25252Fauth%25252F2.0&prevRID=MNHVNFRXMWQ5AKHV9VNN&openid.assoc_handle=amzn_respawn_desktop_br&openid.mode=checkid_setup&prepopulatedLoginId=&failedSignInCount=0&ref_=ap_sw_aa&openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&disableLoginPrepopulate=1&switch_account=signin&openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0");
            FuncoesUteis.pausa(2000);

            //-------------------------------------------DADOS--------------------------------------------------------------------------
            string nome = txt_nome.Text;
            string nome2 = txt_nome2.Text;
            string senhag = "Aa@147369258";
            string prefix = txt_nome.Text + "." + txt_nome2.Text + aleatorio;//prefixo do email que será utilizado nos cadastros
            string email = txt_nome.Text + "." + txt_nome2.Text + aleatorio + "@yahoo.com";
            string telefone = txt_cel.Text;
            string dia = "12";
            string ano = "1995";
            //--------------------------------------------------------------------------------------------------------------------------

            //salvar variaveis em arquivo TXT
            string data = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
            StreamWriter tw = new StreamWriter("c://amzprimecontas/" + data + "-" + txt_nome.Text + "-" + txt_nome2.Text + ".txt");
            tw.WriteLine(email);
            tw.WriteLine(senhag);
            tw.WriteLine(telefone);
            tw.Close();
            // fim do acript do arquivo

            SeleniumMetodos.clickPorXPATH(driver, "/html/body/div[1]/div[1]/div[4]/div[2]/a[1]");//abrir nova guia (clica em um botão com target blank)
            driver.SwitchTo().Window(driver.WindowHandles.Last()); //vai para ultima guia
            driver.Navigate().GoToUrl("https://login.yahoo.com/account/create?.intl=br&.lang=pt-BR&src=ym&activity=ybar-mail&pspid=2142170772&.done=https%3A%2F%2Fmail.yahoo.com%2Fd%2F%3F.intl%3Dbr%26.lang%3Dpt-BR%26pspid%3D2142170772%26activity%3Dybar-mail&specId=yidReg&done=https%3A%2F%2Fmail.yahoo.com%2Fd%2F%3F.intl%3Dbr%26.lang%3Dpt-BR%26pspid%3D2142170772%26activity%3Dybar-mail");

            //preenche os campos nome, sobrenome, nome de usuário, senha e confirmação de senha
            //nome
            char[] campo1 = nome.ToCharArray();
            Random rnd = new Random();
            int zero = 0;
            foreach (var lo in campo1)
            {
                int time = rnd.Next(1, 13);
                FuncoesUteis.pausa(time + zero + zero + zero);
                SeleniumMetodos.preencherTextPorName(driver, lo.ToString(), "firstName");
            }
            FuncoesUteis.pausa(1);
            //sobrenome
            char[] campo2 = nome2.ToCharArray();
            foreach (var se in campo2)
            {
                int time = rnd.Next(1, 13);
                FuncoesUteis.pausa(time + zero + zero + zero);
                SeleniumMetodos.preencherTextPorName(driver, se.ToString(), "lastName");
            }
            FuncoesUteis.pausa(1);
            //nome de usuário (prefixo do email)
            char[] campo3 = prefix.ToCharArray();
            foreach (var se in campo3)
            {
                int time = rnd.Next(1, 13);
                FuncoesUteis.pausa(time + zero + zero + zero);
                SeleniumMetodos.preencherTextPorName(driver, se.ToString(), "yid");
            }
            FuncoesUteis.pausa(1);
            //senha 
            char[] campo4 = senhag.ToCharArray();
            foreach (var se in campo4)
            {
                int time = rnd.Next(1, 13);
                FuncoesUteis.pausa(time + zero + zero + zero);
                SeleniumMetodos.preencherTextPorName(driver, se.ToString(), "password");
               

            }

            //celular
            char[] campo5 = telefone.ToCharArray();
            foreach (var se in campo5)
            {
                int time = rnd.Next(1, 13);
                FuncoesUteis.pausa(time + zero + zero + zero);
                SeleniumMetodos.preencherTextPorName(driver, se.ToString(), "phone");


            }

            //Clica no dropdown do mes

            try
            {
                SeleniumMetodos.clickPorId(driver, "usernamereg-month");
            }
            catch (Exception ex)
            {
                if (ex is OpenQA.Selenium.NoSuchElementException)
                {
                    SeleniumMetodos.clickPorName(driver, "mm");
                }
                else { }
            }

            //seleciona o mes

            SendKeys.Send("{DOWN}");
            SendKeys.Send("{ENTER}");

            //escreve o dia (12)
            char[] campo6 = dia.ToCharArray();
            foreach (var se in campo6)
            {
                int time = rnd.Next(1, 13);
                FuncoesUteis.pausa(time + zero + zero + zero);
                SeleniumMetodos.preencherTextPorName(driver, se.ToString(), "dd");
            }
            FuncoesUteis.pausa(1);

            //escreve o ano (1995)
            char[] campo7 = ano.ToCharArray();
            foreach (var se in campo7)
            {
                int time = rnd.Next(1, 13);
                FuncoesUteis.pausa(time + zero + zero + zero);
                SeleniumMetodos.preencherTextPorName(driver, se.ToString(), "yyyy");
            }
            FuncoesUteis.pausa(1);

            //clica no botão continuar

            try
            {
                SeleniumMetodos.clickTextoPorLink(driver, "Continuar");//tenta localizar o botão pelo texto 
            }
            catch (Exception ex)
            {
                if (ex is OpenQA.Selenium.NoSuchElementException)
                {
                    SeleniumMetodos.clickPorName(driver, "signup");//se não consegue pelo texto vai pelo nome do botão
                }
                else { }
            }

            MessageBox.Show("Resolva o captcha, aperte CONTINUAR (azul no site) e depois aperte OK (aqui em baixo)", "Status do suporte", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);


            //clicar para enviar sms
            try
            {
                SeleniumMetodos.clickPorClasse(driver, "pure-button");//tenta localizar o botão pela classe
            }
            catch (Exception ex)
            {
                if (ex is OpenQA.Selenium.NoSuchElementException)
                {
                    SeleniumMetodos.clickPorName(driver, "sendCode");//se não consegue pela classe vai pelo nome do botão
                }
                else { }
            }

            MessageBox.Show("Coloque o código que chegou via SMS e aperte verificar, depois clique OK quando aparecer o botão azul na tela (não aperte o botão azul)", "Status do suporte", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

            //Clicar em concluído

            try
            {
                SeleniumMetodos.clickTextoPorLink(driver, "Concluído");//tenta localizar o botão pelo texto 
            }
            catch (Exception ex)
            {
                if (ex is OpenQA.Selenium.NoSuchElementException)
                {
                    SeleniumMetodos.clickPorClasse(driver, "pure-button");//se não consegue pelo texto vai pela classe
                }
                else { }
            }

            //clica no botão ok

            try
            {
                SeleniumMetodos.clickTextoPorLink(driver, "OK");//tenta localizar o botão pelo texto 
            }
            catch (Exception ex)
            {
                if (ex is OpenQA.Selenium.NoSuchElementException)
                {
                    SeleniumMetodos.clickPorName(driver, "agree");//se não consegue pelo texto vai pelo nome do botão
                }
                else { }
            }

            //email criado no yahoo...
            //agora criar conta na amazon

            driver.SwitchTo().Window(driver.WindowHandles.First()); //volta para primeira guia

            char[] nomeamz = nome.ToCharArray();
            foreach (var lo in nomeamz)
            {
                int time = rnd.Next(1, 13);
                FuncoesUteis.pausa(time + zero + zero + zero);
                SeleniumMetodos.preencherTextPorName(driver, lo.ToString(), "customerName");
            }
            FuncoesUteis.pausa(1);

            char[] emailamz = email.ToCharArray();
            foreach (var lo in emailamz)
            {
                int time = rnd.Next(1, 13);
                FuncoesUteis.pausa(time + zero + zero + zero);
                SeleniumMetodos.preencherTextPorName(driver, lo.ToString(), "email");
            }
            FuncoesUteis.pausa(1);

            char[] senhaamz = senhag.ToCharArray();
            foreach (var lo in senhaamz)
            {
                int time = rnd.Next(1, 13);
                FuncoesUteis.pausa(time + zero + zero + zero);
                SeleniumMetodos.preencherTextPorName(driver, lo.ToString(), "password");
                SeleniumMetodos.preencherTextPorName(driver, lo.ToString(), "passwordCheck");
            }
            FuncoesUteis.pausa(1);

            SeleniumMetodos.clickPorId(driver, "continue");

            driver.SwitchTo().Window(driver.WindowHandles.Last()); //vai para ultima guia

            FuncoesUteis.pausa(3000);
            SendKeys.SendWait("{F5}");
            FuncoesUteis.pausa(6000);
            SendKeys.SendWait("{ESC}");

            //clica no email da amazon
            SeleniumMetodos.clickPorXPATH(driver, "/html/body/div[1]/div/div[1]/div/div[2]/div/div[2]/div[1]/div/div/div[2]/div/div/div[2]/div/div[1]/ul/li[2]/a/div/div[1]/div[2]/span");
            //armazena o código na variavel 
            string codigoamz = SeleniumMetodos.retornarTextoPorXPATH(driver, "/html/body/div[1]/div/div[1]/div/div[2]/div/div[2]/div[1]/div/div[2]/div[2]/ul/li/div/div/div[1]/div[2]/div/div/div/div/table/tbody/tr/td/table/tbody/tr[2]/td/p[2]");

            driver.SwitchTo().Window(driver.WindowHandles.First()); //volta para primeira guia

            //preenche o código no site da amazon
            char[] codVerAmz = codigoamz.ToCharArray();
            foreach (var lo in codVerAmz)
            {
                int time = rnd.Next(1, 13);
                FuncoesUteis.pausa(time + zero + zero + zero);
                SeleniumMetodos.preencherTextPorName(driver, lo.ToString(), "code");
            }
            FuncoesUteis.pausa(1);                     
            //vai pra tela de login            
            SeleniumMetodos.clickPorXPATH(driver, "/html/body/div[1]/div[2]/div/div/div/div/div/div[1]/form/div[7]/span/span/input");

            //coloca email no login da amazon
            char[] loginamz = email.ToCharArray();
            foreach (var lo in loginamz)
            {
                int time = rnd.Next(1, 13);
                FuncoesUteis.pausa(time + zero + zero + zero);
                SeleniumMetodos.preencherTextPorName(driver, lo.ToString(), "email");
            }
            FuncoesUteis.pausa(1);
            //coloca senha no login da amazon
            char[] senhaamz2 = senhag.ToCharArray();
            foreach (var lo in senhaamz2)
            {
                int time = rnd.Next(1, 13);
                FuncoesUteis.pausa(time + zero + zero + zero);
                SeleniumMetodos.preencherTextPorName(driver, lo.ToString(), "password");
            }
            FuncoesUteis.pausa(1);
            //aperta o sig-in
            SeleniumMetodos.clickPorId(driver, "signInSubmit");

            FuncoesUteis.pausa(3000);

            //clica no "not now" para nao colocar telefone

            try
            {
                SeleniumMetodos.clickTextoPorLink(driver, "Not now");//tenta localizar o botão pelo texto 
            }
            catch (Exception ex)
            {
                if (ex is OpenQA.Selenium.NoSuchElementException)
                {
                    try
                    {
                        SeleniumMetodos.clickPorId(driver, "ap-account-fixup-phone-skip-link");//tenta localizar o botão pelo ID
                    }
                    catch (Exception ex2)
                    {
                        if (ex2 is OpenQA.Selenium.NoSuchElementException)
                        {
                            SeleniumMetodos.clickPorXPATH(driver, "/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div/form/div/div[5]/div/a");//tenta pelo XPATH
                        }
                        else { }
                    }
                }
                else { }
            }


            FuncoesUteis.pausa(3000);

            //clica no botão de assinar o prime

            try
            {
                SeleniumMetodos.clickTextoPorLink(driver, "Experimente Prime");//tenta localizar o botão pelo texto 
            }
            catch (Exception ex)
            {
                if (ex is OpenQA.Selenium.NoSuchElementException)
                {
                    SeleniumMetodos.clickPorClasse(driver, "tw-amazon-ember-bold");//se não consegue pelo texto vai pela classe do botão
                }
                else { }
            }

            //clica no botão continuar para confirmar o país
            FuncoesUteis.pausa(1000);
            try
            {
                SeleniumMetodos.clickTextoPorLink(driver, "Continuar");//tenta localizar o botão pelo texto 
            }
            catch (Exception ex)
            {
                if (ex is OpenQA.Selenium.NoSuchElementException)
                {
                    try
                    {
                        SeleniumMetodos.clickPorClasse(driver, "tw-interactive");//tenta localizar o botão pela classe
                    }
                    catch (Exception ex2)
                    {
                        if (ex2 is OpenQA.Selenium.NoSuchElementException)
                        {
                            SeleniumMetodos.clickPorXPATH(driver, "/html/body/div[3]/div/div/div/div[2]/div[5]/button");//localizar pelo xpath
                        }
                        else { }
                    }
                }
                else { }
            }

            FuncoesUteis.pausa(1000);
            //coloca senha no login da amazon
            char[] senhaamz3 = senhag.ToCharArray();
            foreach (var lo in senhaamz3)
            {
                int time = rnd.Next(1, 13);
                FuncoesUteis.pausa(time + zero + zero + zero);
                SeleniumMetodos.preencherTextPorName(driver, lo.ToString(), "password");
            }
            FuncoesUteis.pausa(1);

            SeleniumMetodos.clickPorId(driver, "signInSubmit");

            FuncoesUteis.pausa(3000);

            //chegou na tela de colocar os dados do cartão

            MessageBox.Show("Para sua segurança, preencha manualmente os dados do cartão de crédito", "Status do suporte", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            MessageBox.Show("Recomendo utilizar um cartão virtual, assim que o prime for ativado exclua o cartão virtual e o dinheiro cobrado retornará para seu limite em poucos minutos", "Status do suporte", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            MessageBox.Show("Quando terminar de colocar os dados e confirmar não aperte mais em nada no site e clique em OK", "Status do suporte", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            MessageBox.Show("Terminou mesmo? não preencha o endereço e Clique em OK", "Status do suporte", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

            //colocar endereço

            string linha1 = "Av Brg Faria Lima";
            string linha2 = "3477 18 Andar Itaim Bibi";
            string cidade = "São Paulo";
            string cep = "04538133";


            //colocar linha 1 de endereço
            char[] linha11 = linha1.ToCharArray();
            foreach (var lo in linha11)
            {
                int time = rnd.Next(1, 13);
                FuncoesUteis.pausa(time + zero + zero + zero);
                SeleniumMetodos.preencherTextPorName(driver, lo.ToString(), "ppw-line1");
            }
            FuncoesUteis.pausa(1);

            //colocar linha 2 de endereço
            char[] linha22 = linha2.ToCharArray();
            foreach (var lo in linha22)
            {
                int time = rnd.Next(1, 13);
                FuncoesUteis.pausa(time + zero + zero + zero);
                SeleniumMetodos.preencherTextPorName(driver, lo.ToString(), "ppw-line2");
            }
            FuncoesUteis.pausa(1);

            //colocar cidade
            char[] cidadee = cidade.ToCharArray();
            foreach (var lo in cidadee)
            {
                int time = rnd.Next(1, 13);
                FuncoesUteis.pausa(time + zero + zero + zero);
                SeleniumMetodos.preencherTextPorName(driver, lo.ToString(), "ppw-city");
                SeleniumMetodos.preencherTextPorName(driver, lo.ToString(), "ppw-stateOrRegion");
            }
            FuncoesUteis.pausa(1);

            //colocar telefone
            char[] telefonee = telefone.ToCharArray();
            foreach (var lo in telefonee)
            {
                int time = rnd.Next(1, 13);
                FuncoesUteis.pausa(time + zero + zero + zero);
                SeleniumMetodos.preencherTextPorName(driver, lo.ToString(), "ppw-phoneNumber");
            }
            FuncoesUteis.pausa(1);

            //clicar no botão de confirmar endereço
            try
            {
                SeleniumMetodos.clickPorClasse(driver, "a-button-input");
            }
            catch (Exception ex)
            {
                if (ex is OpenQA.Selenium.NoSuchElementException)
                {
                    SeleniumMetodos.clickPorName(driver, "ppw-widgetEvent:AddAddressEvent");
                }
                else { }
            }

            //aqui as vezes pede pra colocar senha, as vzs vai direto para a página de confirmar e se atualiza pode pedir CPF ... tem que ver
            //
            //                      pulei essa parte, depois eu faço
            //
            //
            //-------------------------------------------------------------------------------------------------------------------------------
            MessageBox.Show("Parada da confirmação de senha/confirmar compra/CPF ... se tiver na parte do CPF aperta OK, se nao tiver vai mechendo até chegar nela, a senha é Aa@147369258 ", "Status do suporte", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);


            //gerador de CPF
            driver.SwitchTo().Window(driver.WindowHandles.Last()); //vai para ultima guia

            driver.Navigate().GoToUrl("https://www.4devs.com.br/gerador_de_cpf");

            FuncoesUteis.pausa(3000);

            //clica no botão gerar CPF
            try
            {
                SeleniumMetodos.clickPorId(driver, "bt_gerar_cpf");
            }
            catch (Exception ex)
            {
                if (ex is OpenQA.Selenium.NoSuchElementException)
                {
                    SeleniumMetodos.clickPorXPATH(driver, "/html/body/main/div/div[2]/div/div[4]/div[1]/div[3]/label/input");
                }
                else { }
            }

            //clica no botãozinho de copiar
            try
            {
                SeleniumMetodos.clickPorClasse(driver, "clipboard-copy");
            }
            catch (Exception ex)
            {
                if (ex is OpenQA.Selenium.NoSuchElementException)
                {
                    SeleniumMetodos.clickPorXPATH(driver, "/html/body/main/div/div[2]/div/div[4]/div[1]/div[4]/div[1]/div[2]/span");
                }
                else { }
            }

            driver.SwitchTo().Window(driver.WindowHandles.First()); //volta para primeira guia

            //clica no campo de cpf e da o ctrl+v
            try
            {
                SeleniumMetodos.clickPorClasse(driver, "DVPAWebWidgetsTaxCode_TaxCode__inputText");
            }
            catch (Exception ex)
            {
                if (ex is OpenQA.Selenium.NoSuchElementException)
                {
                    SeleniumMetodos.clickPorXPATH(driver, "/html/body/div[1]/div/div[2]/div/div[3]/div/div/form/div/input[2]");
                }
                else { }
            }
            //ctrl+v
            SendKeys.Send("^{v}");

            MessageBox.Show("Esqueci de pegar o endereço do botão de confirmar cpf :/", "Status do suporte", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);


















            MessageBox.Show("Parada de emergencia", "Status do suporte", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);



            driver.Navigate().GoToUrl("https://www.invertexto.com/gerador-email-temporario?");
            FuncoesUteis.pausa(4000);

            SeleniumMetodos.clickPorId(driver, "editar");


            char[] mudaremail = prefix.ToCharArray();
            //Random rnd = new Random();
            //int zero = 0;
            foreach (var lo in mudaremail)
            {
                int time = rnd.Next(1, 13);
                FuncoesUteis.pausa(time + zero + zero + zero);
                SeleniumMetodos.preencherTextPorId(driver, lo.ToString(), "new_email");
            }
            FuncoesUteis.pausa(1);

            SeleniumMetodos.clickPorId(driver, "change");














































            //-------------------------------------------------------------------------------
            //preenche os campos nome, sobrenome, nome de usuário, senha e confirmação de senha
            //nome
            //char[] campo1 = nome.ToCharArray();
            foreach (var lo in campo1)
            {
                int time = rnd.Next(1, 13);
                FuncoesUteis.pausa(time + zero + zero + zero);
                SeleniumMetodos.preencherTextPorName(driver, lo.ToString(), "firstName");
            }
            FuncoesUteis.pausa(1);
            //sobrenome
            //char[] campo2 = nome2.ToCharArray();
            foreach (var se in campo2)
            {
                int time = rnd.Next(1, 13);
                FuncoesUteis.pausa(time + zero + zero + zero);
                SeleniumMetodos.preencherTextPorName(driver, se.ToString(), "lastName");
            }
            FuncoesUteis.pausa(1);
            //nome de usuário (prefixo do email)
            //char[] campo3 = email.ToCharArray();
            foreach (var se in campo3)
            {
                int time = rnd.Next(1, 13);
                FuncoesUteis.pausa(time + zero + zero + zero);
                SeleniumMetodos.preencherTextPorName(driver, se.ToString(), "Username");
            }
            FuncoesUteis.pausa(1);
            //senha e confirmação de senha
            //char[] campo4 = senhag.ToCharArray();
            foreach (var se in campo4)
            {
                int time = rnd.Next(1, 13);
                FuncoesUteis.pausa(time + zero + zero + zero);
                SeleniumMetodos.preencherTextPorName(driver, se.ToString(), "Passwd");
                SeleniumMetodos.preencherTextPorName(driver, se.ToString(), "ConfirmPasswd");

            }
            
            FuncoesUteis.pausa(1);

            //clica no botão próximo

            try
            {
                SeleniumMetodos.clickTextoPorLink(driver, "Próxima");//tenta localizar o botão pelo texto 
            }
            catch (Exception ex)
            {
                if (ex is OpenQA.Selenium.NoSuchElementException)
                {
                    SeleniumMetodos.clickPorClasse(driver, "VfPpkd-vQzf8d");//se não consegue pelo texto vai pela classe do botão
                }
                else { }
            }








            MessageBox.Show("Parada de emergencia", "Status do suporte", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            //prenche form 
            string pesquisa = txt_nome2.Text + " na região de " + txt_nome.Text + " "  ; 

            // faz a pesquisa com os dados que foram colocados no form 
            SeleniumMetodos.preencherTextPorName(driver, pesquisa, "q");
            SendKeys.Send("{ENTER}");

            //Entra no mapa
            SeleniumMetodos.clickTextoPorLink(driver, "Maps");
            //SeleniumMetodos.clickPorXPATH(driver, "/html/body/div[7]/div/div[4]/div/div[1]/div/div[1]/div/div[2]/a");
            FuncoesUteis.pausa(2000);

            
            // coloca o cursor sobre a lista
            //SeleniumMetodos.moverAteElementoPorXpath(driver, "/html/body/div[3]/div[9]/div[8]/div/div[1]/div/div/div[2]/div[1]");

            string texto = "";
            string separador = "\n\n------------------\n\n";
            int verificador = 0;
            int contador = 0;

            
                do
                {
                    contador++;
                    // clica no segundo item da pesquisa, para entrar no carrosel 
                    SeleniumMetodos.rClickPorXPATH(driver, "/html/body/div[3]/div[9]/div[8]/div/div[1]/div/div/div[2]/div[1]/div[5]/div/a");
                    FuncoesUteis.pausa(1000);
                    SendKeys.Send("{ESC}");

                    for (int x = 0; x < 150; x++)
                    {
                        SendKeys.Send("{DOWN}");
                    }

                    //copia o nome do local e armazena na variavel
                    string nome4 = SeleniumMetodos.retornarTextoPorXPATH(driver, "/html/body/div[3]/div[9]/div[8]/div/div[1]/div/div/div[2]/div[1]");
                    //string nome = SeleniumMetodos.retornarTextoPorXPATH(driver, "/html/body/div[3]/div[9]/div[8]/div/div[1]/div/div/div[2]/div[1]/div[1]/div[1]/h1/span[1]");//XPATH DO SPAN COM TEXTO, mudar caso necessário
                    FuncoesUteis.pausa(2000);

                    try {
                        SeleniumMetodos.clickPorXPATH(driver, "/html/body/div[3]/div[9]/div[8]/div/div[1]/div/div/div[2]/div[2]/div/div[1]/div/button[2]/img");
                        FuncoesUteis.pausa(5000);
                    }

                    catch (Exception ex)
                    {
                        //Catches every exception
                        if (ex is OpenQA.Selenium.ElementClickInterceptedException)
                        {
                            verificador = 1;
                        }
                        else
                        {
                            //If there's an icon throw the exception
                            //Here you can throw a custom exception
                            throw ex;
                        }
                    }

                    texto += nome + separador;
                } while ((verificador <= 0)||(contador>=3));
            
            
            
            //MessageBox.Show(texto);

            

            FuncoesUteis.pausa(1500);
            SeleniumMetodos.fecharDriver(driver);


            //-------------------------------------------PARTES DE CODIGO QUE EU POSSA QUERER USAR DEPOIS------------------------------------------------------
            //Faz o scrol pra baixo
            /*IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("element = document.getElementsByClassName(\"rogA2c\")[0]; element.scrollIntoView(); ");
            FuncoesUteis.pausa(1500);*/

            /* SendKeys.Send("^{c}");
             SendKeys.Send("^{v}");*/

            /*IWebElement informacoes = driver.FindElement(By.XPath("//*[@id=\"pane\"]/div/div[1]/div/div/div[9]"));
            List<IWebElement> telefones = new List<IWebElement>();
            telefones = informacoes.FindElements(By.XPath("//*[@id=\"pane\"]/div/div[1]/div/div/div[9]/div[7]/button/div[1]/div[2]")).ToList();
            int contador = 0;
            //telefones = informacoes.FindElements(By.ClassName("rogA2c"))
            foreach (var item in telefones)
            {
                contador++;
                if (contador == 7 )
                {
                    telefone = item.Text;
                }
            }*/

















        }

    private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_regiao_Click(object sender, EventArgs e)
        {

        }

        private void txt_publicoAlvo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        //parar execução

    }

    
}
