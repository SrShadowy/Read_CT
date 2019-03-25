using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Memory;
using Microsoft.VisualBasic;

namespace XML_CHEAT
{
    public partial class form1 : Form
    {
        public static string Nomes { get; set; }

        public form1()
        {
            InitializeComponent();
        }

        OpenFileDialog abrir_arquivo = new OpenFileDialog();
        DataSet dsResultado = new DataSet();
        Mem m = new Mem();   

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "Process ID : " + Nomes;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            var result = new DialogResult();
            result = abrir_arquivo.ShowDialog();
            if (DialogResult.OK == result) {
                dsResultado.ReadXml(abrir_arquivo.FileName);
                label1.Text = abrir_arquivo.FileName;
                bnt_loading_ct.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form x = new Processss();
            x.ShowDialog();
            Nomes = Interaction.InputBox("Nome do processo", "X", Nomes);
            m.OpenProcess(Nomes);
            label3.Text = "Process ID : " + m.procID;

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            XmlTextReader xmlReader = new XmlTextReader(abrir_arquivo.FileName);
            string val = "";
            //int index = 0;
            bool pode = false;
            while (xmlReader.Read())
            {
                switch (xmlReader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (xmlReader.Name == "CheatEntry" && textBox2.Text != "")
                            textBox2.AppendText(Environment.NewLine);

                        if (xmlReader.Name == "Description" || xmlReader.Name == "VariableType" || xmlReader.Name == "Address" || xmlReader.Name == "Offset")
                            pode = true;
                        else
                            pode = false;

                       
                        break;
                    case XmlNodeType.Text:
                       
                         if (pode)
                             val = val + (xmlReader.Value) + "|";
                      
                        break;
                    case XmlNodeType.EndElement:

                        textBox2.AppendText(val);
                      
                        val = "";
                       
                        break;
                    case XmlNodeType.XmlDeclaration:
                       
                        break;

                }

            }
            listBox2.Items.Clear();

            for (int x = 0; x < textBox2.Lines.Length; ++x)
                listBox2.Items.Add(textBox2.Lines[x]);



        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string addroff;
                string textdelimitar = listBox2.SelectedItem.ToString();
                string[] full = textdelimitar.Split('|'); //Quando maior que 5 tem offsets

                if (full.Length > 4) {
                    addroff = full[2].Replace("\"", string.Empty);
                    for (int x = full.Length -1; x > 2; --x)
                    {
                        addroff = addroff + full[x];

                        if (x != 3)
                          addroff = addroff + ",";
                     
                    }

                    textBox2.AppendText(addroff + Environment.NewLine);
                }
                else
                    addroff = full[2];


                for (int i = 0; i < full.Length; ++i) {
                    textBox2.AppendText(full[i] + "  ");
                }
                label4.Text = addroff;
                if (full[1] == "4 Bytes")
                {
                    int num = m.readInt(addroff);
                    label5.Text = num.ToString();
                }
                else if (full[1] == "2 Bytes")
                {
                    label4.Text = m.read2Byte(addroff).ToString();
                }else if (full[1] == "Float")
                {

                    label4.Text = m.readFloat(addroff).ToString();

                }

            }
            catch
            {
            }
        }

        private void bnt_write_all_Click(object sender, EventArgs e)
        {
            string addroff;
            string textdelimitar = listBox2.SelectedItem.ToString();
            string[] full = textdelimitar.Split('|'); //Quando maior que 4 tem offsets
            if (full.Length > 4)
            {
                addroff = full[2].Replace("\"", string.Empty);
                for (int x = full.Length -1; x > 2; --x)
                {
                    addroff = addroff + full[x];

                    if (x != 3)
                      addroff = addroff + ",";
              
                }
                textBox2.AppendText(addroff + Environment.NewLine);
            }
            else
                addroff = full[2];


            for (int i = 0; i < full.Length; ++i)
            {
                textBox2.AppendText(full[i] + "  ");
            }
            label4.Text = addroff;
            string value = Interaction.InputBox("Coloqueo o valor desejado", "Titulo sei la oque valor vc vai por", "100");

            if (full[1] == "4 Bytes" || full[1] == "2 Bytes" || full[1] == "8 Bytes" )
            {
                
                m.writeMemory(addroff, "int", value);
            }
            else if (full[1] == "Float")
            {
                m.writeMemory(addroff, "Float",value);
            }
         
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bnt_clr_gr_Click(object sender, EventArgs e)
        {
            TexCod.Text = "";
        }

        private void bnt_gr_cpp_Click(object sender, EventArgs e)
        {
            string addroff;
            int pindex = -1;
            string textdelimitar = listBox2.SelectedItem.ToString();
            string[] full = textdelimitar.Split('|'); //Quando maior que 4 tem offsets
           // addroff = full[2].Replace("\"", string.Empty);
            string STRINGTYPE = "int";
            string STRING_MODULE = full[2];
            string STRING_ADDY = "0x00";
            string STRING_VAR = "0"; // = offsets


            if (full.Length > 4)
            {
                STRING_VAR = "0x";
                for (int x = full.Length-1; x > 2; --x)
                {
                   
                    STRING_VAR = STRING_VAR + full[x];
                    ++pindex;
                    if (x != 3 && x < full.Length - 1) { 
                    
                    STRING_VAR =  STRING_VAR + ",0x";
                    }

                }
                textBox2.AppendText(Environment.NewLine + STRING_VAR + Environment.NewLine + pindex);
               

                try
                {
                    string[] AM = STRING_MODULE.Split('+');
                    STRING_MODULE = AM[0];
                    STRING_ADDY = AM[1];
                }
                catch
                {
                    STRING_ADDY = STRING_MODULE;
                    STRING_MODULE = "0";

                }

            }
            else { 
                addroff = full[2];
                STRING_ADDY = addroff;
                STRING_MODULE = "0";

            }

            if (full[1] == "4 Bytes" || full[1] == "2 Bytes" || full[1] == "8 Bytes")
            {
                STRINGTYPE = "int";

            }
            else if (full[1] == "Float")
            {
                STRINGTYPE = "float";
            }

            string STRINGNOME = full[0].Replace("\"", string.Empty); 
           
            string windowsclass, windowstext;
            windowsclass = Interaction.InputBox("Coloque o nome da WINDOWS CLASS Do processo esse passo é opcional coloque null para passar", "WINDOWS CLASS", "NULL");
            windowstext = Interaction.InputBox("* OBRIGATORIO - Coloque o nome da janela completo e sem error para que funcione perfeitamente ", "Windows Title");

            var headersandPOINTER = "#include <windows.h>" + Environment.NewLine + "#include <iostream>" + Environment.NewLine + "#include<TlHelp32.h>" + Environment.NewLine + " #include <tchar.h>" + Environment.NewLine + "DWORD pid; " + Environment.NewLine + " //THANKS https://guidedhacking.com - GET POINTER ADDY " + Environment.NewLine + " DWORD FindDmaAddy(int PointerLevel,HANDLE hProcHandle, DWORD Offsets[], DWORD BaseAddress) " + Environment.NewLine + " { " + Environment.NewLine + Environment.NewLine + " DWORD pointer = BaseAddress; " + Environment.NewLine + " DWORD pTemp; " + Environment.NewLine + " DWORD pointerAddr;" + Environment.NewLine + " for (int i = 0; i < PointerLevel; i++)" + Environment.NewLine + "  {" + Environment.NewLine +
" if (i == 0) " + Environment.NewLine + "{" + Environment.NewLine + " ReadProcessMemory(hProcHandle, (LPCVOID)pointer, &pTemp, 4, NULL);" + Environment.NewLine + "  }" + Environment.NewLine + "pointerAddr = pTemp + Offsets[i];" + Environment.NewLine + Environment.NewLine + Environment.NewLine + " ReadProcessMemory(hProcHandle, (LPCVOID)pointerAddr, &pTemp, 4, NULL);" + Environment.NewLine +
 "   }" + Environment.NewLine + "  return pointerAddr; " + Environment.NewLine + "}" + Environment.NewLine;

            var functionModuleAddy = "//THANKS https://guidedhacking.com GET MODULE ADDY" + Environment.NewLine + "DWORD dwGetModuleBaseAddress(TCHAR *lpszModuleName, DWORD pID) {" + Environment.NewLine + "	DWORD dwModuleBaseAddress = 0;" + Environment.NewLine + "	HANDLE hSnapshot = CreateToolhelp32Snapshot(TH32CS_SNAPMODULE, pID);" + Environment.NewLine + "	MODULEENTRY32 ModuleEntry32 = { 0 };" + Environment.NewLine +
"	ModuleEntry32.dwSize = sizeof(MODULEENTRY32);" + Environment.NewLine + Environment.NewLine + "	if (Module32First(hSnapshot, &ModuleEntry32))" + Environment.NewLine + "	{" + Environment.NewLine + "		do {" + Environment.NewLine + "			if (_tcscmp(ModuleEntry32.szModule, lpszModuleName) == 0)" + Environment.NewLine +
"			{" + Environment.NewLine + "				dwModuleBaseAddress = (DWORD)ModuleEntry32.modBaseAddr;" + Environment.NewLine + "				break;" + Environment.NewLine + "			}" + Environment.NewLine + "		} while (Module32Next(hSnapshot, &ModuleEntry32));" + Environment.NewLine + Environment.NewLine + "	}" + Environment.NewLine + "	CloseHandle(hSnapshot);" + Environment.NewLine + "	return dwModuleBaseAddress;" + Environment.NewLine + "}" + Environment.NewLine;



            var textomain = "int main() {" + Environment.NewLine +"	HWND hGameWindow = NULL;" + Environment.NewLine +"	hGameWindow = FindWindow(" + '"' + windowsclass + '"' + "," + '"' + windowstext + '"' + ");" + Environment.NewLine +"	GetWindowThreadProcessId(hGameWindow, &pid);" + Environment.NewLine +"	HANDLE phandle = OpenProcess(PROCESS_ALL_ACCESS, 0, pid);" + Environment.NewLine +
"	std::cout << " + '"' + " Lets check pid of process:  " + '"' + "  << pid << " + '"' + " if okey ? Lets Go! \n\n " + '"' + "<< std::endl;" + Environment.NewLine +Environment.NewLine +"	// WRITE OR READ MEMORY" + Environment.NewLine +Environment.NewLine +"	//============================READ=====================================//" + Environment.NewLine +
Environment.NewLine +"	DWORD  Offsets[] = { " + STRING_VAR + "};" + Environment.NewLine +"	uintptr_t BsA = dwGetModuleBaseAddress((TCHAR*)" + STRING_MODULE + ", pid);" + Environment.NewLine +"	BsA = BsA + 0x" + STRING_ADDY + ";" + Environment.NewLine +"	uintptr_t " + STRINGNOME + "  = FindDmaAddy(" + pindex + ", phandle, Offsets, BsA);" + Environment.NewLine +"	std::cout <<  " + '"' + " THIS IS A ADDY  " + '"' + "  << std::endl;" + Environment.NewLine +
"	std::cout << std::hex << " + STRINGNOME + "  << std::endl;" + Environment.NewLine +"    "+STRINGTYPE +" r_" +STRINGNOME + " = 0; "+ Environment.NewLine +"	ReadProcessMemory(phandle, (LPVOID)" + STRINGNOME + " , &r_" + STRINGNOME + ", sizeof(" + STRINGNOME + " ), NULL);" + Environment.NewLine +
"	std::cout <<"+ '"'+ "THIS IS A VALUE" + '"'+ " << std::endl;" + Environment.NewLine +"	std::cout << r_" + STRINGNOME + "  << std::endl;" + Environment.NewLine +"	Sleep(100);" + Environment.NewLine +"	//============================READ=====================================//" + Environment.NewLine +
Environment.NewLine +"	//============================WRITE=====================================//" + Environment.NewLine +"	std::cout << std::endl <<  " + '"' + "\n\n OK OK SET YOU PREFERENCE VALUE NEW :  " + '"' + ";" + Environment.NewLine +"	std::cin >> r_" + STRINGNOME + ";" + Environment.NewLine +
"	WriteProcessMemory(phandle, (LPVOID)" + STRINGNOME + " , &r_" + STRINGNOME + ", sizeof(" + STRINGNOME + " ), nullptr);" + Environment.NewLine +"	Sleep(100);" + Environment.NewLine +"	std::cout << std::endl <<  " + '"' + "If okey thks of user me :D bye bye" + '"' + "; "+ Environment.NewLine +"	//============================WRITE=====================================//" + Environment.NewLine +"	system(" + '"' + "pause" + '"' + "); "+ Environment.NewLine +"	return 0;}";


            TexCod.AppendText(headersandPOINTER + Environment.NewLine + functionModuleAddy + Environment.NewLine + textomain
            );

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string addroff;
            int pindex = -1;
            string textdelimitar = listBox2.SelectedItem.ToString();
            string[] full = textdelimitar.Split('|');

            string VarValue = "100", VarNome = "Vida", VarModule = "glh", VarOffset = "0x20", VarAddy = "0x0";
            VarModule = full[2];
            VarNome = full[0].Replace("\"", string.Empty); //full[2].Replace("\"", string.Empty);
            VarValue = Interaction.InputBox("Valor para ser subistuido", "Value", "100");
            if (full.Length > 4)
            {
                VarOffset = "0x";
                for (int x = full.Length - 1; x > 2; --x)
                {

                    VarOffset = VarOffset + full[x];
                    ++pindex;
                    if (x != 3 && x < full.Length - 1)
                    {

                        VarOffset = VarOffset + ",0x";
                    }

                }
                textBox2.AppendText(Environment.NewLine + VarOffset + Environment.NewLine + pindex);
                try { 
                string[] AM = VarModule.Split('+');
                VarModule = AM[0];
                VarAddy = AM[1];
                }
                catch
                {
                    VarAddy = VarModule;
                    VarModule = "0";
                    
                }

            }
            else
            {
                addroff = full[2];
                VarAddy = addroff;
                VarModule = "0";

            }



            var textdlll = "#pragma warning(disable:4996)" + Environment.NewLine +"#ifdef _MSC_VER" + Environment.NewLine +"#define _CRT_SECURE_NO_WARNINGS" + Environment.NewLine +"#endif" + Environment.NewLine +"#include <iostream>" + Environment.NewLine +
"#include <windows.h>" + Environment.NewLine +"#include <vector>" + Environment.NewLine +Environment.NewLine +
"using std::cout;" + Environment.NewLine +
 Environment.NewLine +
"void  OpenConsole()" + Environment.NewLine +
"{" + Environment.NewLine +
"	AllocConsole();" + Environment.NewLine +
"	freopen(" + '"' + "CONIN$ " +'"'+ "  ,  "+'"'+ "r" +'"'+ ", stdin);" + Environment.NewLine +
"	freopen(" + '"' + "CONOUT$ " + '"' + "  ,  " + '"' + "w" + '"' + ", stdout);" + Environment.NewLine +
"	freopen(" + '"' + "CONOUT$ " + '"' + "  ,  " + '"' + "w" + '"' + ", stderr);" + Environment.NewLine +
"	SetConsoleTitle(L"+VarModule+");" + Environment.NewLine +
"}" + Environment.NewLine +
 Environment.NewLine +
"//SmollICE thks " + Environment.NewLine +
"template<typename T>" + Environment.NewLine +
"bool Addy(uintptr_t Addrs, std::vector<uint32_t> offsets, T value)" + Environment.NewLine +
"{" + Environment.NewLine +
"	if (!offsets.empty())" + Environment.NewLine +
"	{" + Environment.NewLine +
"		DWORD protect = 0;" + Environment.NewLine +
"		auto uAddress = Addrs;" + Environment.NewLine +
"		for (auto& offset : offsets)" + Environment.NewLine +
"		{" + Environment.NewLine +
"			uAddress = *reinterpret_cast<uintptr_t*>(uAddress);" + Environment.NewLine +
"			uAddress += offset;" + Environment.NewLine +
"		}" + Environment.NewLine +
"		cout << std::hex << (DWORD*)uAddress << "+'"'+ "-------" + '"'+" << std::dec << *(float*)uAddress << std::endl;" + Environment.NewLine +
"		if (VirtualProtect(reinterpret_cast<PVOID>(uAddress), sizeof(T), PAGE_EXECUTE_READWRITE, &protect))" + Environment.NewLine +
"		{" + Environment.NewLine +
"			*reinterpret_cast<T*>(uAddress) =  value;" + Environment.NewLine +
"			VirtualProtect(reinterpret_cast<PVOID>(uAddress), sizeof(T), protect, &protect);" + Environment.NewLine +
"			return true;" + Environment.NewLine +
"		}" + Environment.NewLine +
"	}" + Environment.NewLine +
"	return false;" + Environment.NewLine +
"}" + Environment.NewLine +
"DWORD WINAPI IniComds(LPVOID cheatyeah) {" + Environment.NewLine +
"	std::vector<uint32_t> offset{ " + VarOffset + "};" + Environment.NewLine +
"	uintptr_t "  + VarNome  + " = (int)GetModuleHandle(L" + VarModule + ") + 0x"+ VarAddy+";" + Environment.NewLine +
"	cout << " + '"' + @" --------------------------------------------------------------------------------------------------\n" + '"' + ";" + Environment.NewLine +
"	cout << " + '"' + @"--------------------------------------------CHEAT-------------------------------------------------\n" + '"' + ";" + Environment.NewLine +
"	cout << " + '"' + @"--------------------------------------------------------------------------------------------------\n" + '"' + ";" + Environment.NewLine +
"	cout << " + '"' + @"----------------------------------------Press F1--------------------------------------------------\n" + '"' + ";" + Environment.NewLine +
"	while (true) {" + Environment.NewLine +
"		if (GetAsyncKeyState(VK_F1) & 1) {" + Environment.NewLine +
"			Addy(" + VarNome + ", offset, " + VarValue + ");" + Environment.NewLine +
"		}" + Environment.NewLine +
 Environment.NewLine +
"	}" + Environment.NewLine +
Environment.NewLine +
"	return 0;" + Environment.NewLine +
"}" + Environment.NewLine +
 Environment.NewLine +
 Environment.NewLine +
"BOOL APIENTRY DllMain(HMODULE hModule,DWORD  dReason,LPVOID lpReserved)" + Environment.NewLine + "{" + Environment.NewLine + "	if (dReason == DLL_PROCESS_ATTACH) {" + Environment.NewLine + "		OpenConsole();" + Environment.NewLine + "		CreateThread(NULL, NULL, IniComds, NULL, NULL, NULL);" + Environment.NewLine + "	}" + Environment.NewLine + "	return TRUE;}" + Environment.NewLine;

            TexCod.AppendText(textdlll);
        }
    }
}
