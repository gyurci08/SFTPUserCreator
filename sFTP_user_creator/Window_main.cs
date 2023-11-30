using Services;
using sFTP_user_creator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Window_main : Form
    {
        List<string> commands = new List<string>();
        LogWriter logWriter = new LogWriter();
        AlignedLineCreator lineCreator = new AlignedLineCreator();

        public Window_main()
        {
            InitializeComponent();
        }

        private void Window_main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void generate_bt_Click(object sender, EventArgs e)
        {
            commands.Clear();
            generatedCommand_tb.Text = "";
            

            string username = username_tb.Text.Replace(",}", "}");
            string group = group_tb.Text;
            string password = "";
            string system = system_tb.Text.ToUpper();
            string parentHome = parentHome_tb.Text;
            string dirs = home_tb.Text = home_tb.Text.Replace(",",";");
            string keyFile = keys_tb.Text;
            string pubKey = publicKey_tb.Text;
            string pubSub="";


            List<string> users = new List<string>(); ;
            Boolean moreUser = false;
            Boolean commaFail = false;


            Boolean pubKeyEmpty = true;

            int lineWidth = 65;

            Boolean existsEmpty = false;

            DateTime dt = DateTime.Now;
            string logDir = "./Log/";
            string path = "./Log/" +system+"_"+dt.Year.ToString()+"-"+ dt.Month.ToString()+"-"+ dt.Day.ToString() + "_" + username + ".txt";
          
            
            

            int plusDir=0;


   



            logWriter.checkFolder(logDir);



            if (username.Length == 0 || system.Length == 0 )
                {
                    existsEmpty = true;
                    MessageBox.Show("There are empty fields!");
                }
            else
                {
                    existsEmpty = false;
                    commaFail = false;

                    if (pubKey.Length < 1) { pubKeyEmpty = true; }
                    else { pubKeyEmpty = false; }

                    pass_tb.Text = password = PasswordGenerator.Generate(12, 2);
                    
                    if (username.Contains(",") && !username.Contains("{") && !username.Contains("}"))
                    {
                        //commaFail = true;
                        //MessageBox.Show("There is comma without brackets... The right format: {user1,user2}");
                        username = username_tb.Text = username.Insert(0, "{").Insert(username.Length+1, "}");


                        moreUser = true;


                        int commas = username.Length - username.Replace(",", "").Length;


                        for (int i = 0; i <= commas; i++)
                        {
                            users.Add(username.Split(',')[i].Replace("{", "").Replace("}", ""));
                        }
                    }
                    else
                    {
                            moreUser = true;


                            int commas = username.Length - username.Replace(",", "").Length;


                            for (int i = 0; i <= commas; i++)
                            {
                                users.Add(username.Split(',')[i].Replace("{", "").Replace("}", ""));
                            }
                    }



            }






            if (!existsEmpty)  
            {
                
             




                //directories.Add(dirs.Split(';')[0]);
                if (dirs.Length > 0)
                    {
                        plusDir = 1;
                        foreach (char ch in dirs)
                        {
                            if (ch == ';')
                            {
                                plusDir++;
                            }
                        }
                    }

                //List user data
                commands.Add(lineCreator.aligned(" User data ", lineWidth));
                commands.Add(String.Format("## System:  \t{0}",system));
                commands.Add(String.Format("## User:    \t{0}", username));
                commands.Add(String.Format("## Pass:    \t{0}", password));
                commands.Add(String.Format("## Home:    \t{0}{1}\n", parentHome,username));
                commands.Add(lineCreator.aligned("", lineWidth));


                




                //Home and directories
                    commands.Add(lineCreator.aligned(" Before CAMP user created ", lineWidth));
                    commands.Add("#");
                    commands.Add(String.Format("mkdir -p {0}{1}", parentHome, username));
                    for (int i = 0; i < plusDir; i++)
                        {
                            if (dirs.Split(';')[i].Length > 0) 
                                    { 
                                        commands.Add(String.Format("mkdir -p {0}{1}/{2}", parentHome, username, dirs.Split(';')[i].Replace(" ",""))); 
                                    }
                        }
                    commands.Add("#");
                    commands.Add(String.Format("chmod -R 770 {0}{1}", parentHome, username));
                    commands.Add("");

                    commands.Add(lineCreator.aligned(" After CAMP user created ", lineWidth));
                    commands.Add("#");
                    if (moreUser) 
                        {
                            foreach (string user in users)
                                {
                                    commands.Add(String.Format("chown -R {1}:{0} {2}{1}", group, user, parentHome));
                                }
                        }
                    else 
                        {
                            commands.Add(String.Format("chown -R {1}:{0} {2}{1}", group, username, parentHome));
                        }
                    commands.Add("");

                if (!pubKeyEmpty)
                {
                    try
                    {
                        pubSub = pubKey.Substring(0, 100);
                    }
                    catch (Exception)
                    {
                        pubSub = pubKey.Substring(0, 1);
                    }




                    //SSH key
                    commands.Add(lineCreator.aligned(" Public key installition ", lineWidth));
                        commands.Add("#");
                        commands.Add(String.Format("mkdir -p {0}{1}/.ssh/", keyFile, username));
                        commands.Add("#");
                        commands.Add(String.Format("chmod -R 700 {0}{1}", keyFile, username));
                        commands.Add("#");
                        commands.Add(String.Format("echo \"{0}\" | tee {1}{2}/.ssh/authorized_keys", pubKey, keyFile, username));
                        commands.Add("#");
                        commands.Add(String.Format("chmod 644 {0}{1}/.ssh/authorized_keys", keyFile, username));
                        commands.Add("#");
                        if (moreUser)
                        {
                            foreach (string user in users)
                            {
                                commands.Add(String.Format("chown -R {1}:{0} {2}{1}", group, user, keyFile));
                            }
                        }
                        else
                        {
                            commands.Add(String.Format("chown -R {1}:{0} {2}{1}", group, username, keyFile));
                        }
                    commands.Add("");
                }

                // Test
                commands.Add(lineCreator.aligned(" Check user creation ", lineWidth));
                commands.Add("#");
                commands.Add(String.Format("printf '\\n'  && getent passwd | grep {1} && ll {0} | grep {1} && printf '\\n'\r", parentHome, username, keyFile));



                if (!pubKeyEmpty)
                {
                    commands.Add("#");
                    commands.Add(String.Format("printf '\\n' && ll {2}{1}/.ssh/authorized_keys && grep  \"{3}\" {2}{1}/.ssh/authorized_keys  && printf '\\n'\r\n", parentHome, username, keyFile, pubSub));
                }



                // Check user user messages

                commands.Add("");
                commands.Add(lineCreator.aligned(" View user messages ", lineWidth));
                commands.Add("#");
                commands.Add(String.Format("grep \"{0}\" /var/log/messages | tail", username));
                commands.Add("#");
                commands.Add(String.Format("grep \"{0}\" `ps -ef | grep \"/sbin/sshd\" | grep \"/logfile\" | awk \'{{print $13}}\'` | tail", username));
                


                // Unlock user
                commands.Add("");
                commands.Add(lineCreator.aligned(" Unlock user ", lineWidth));
                commands.Add("#");
                if (moreUser)
                {
                    string pam="";
                    foreach (string user in users)
                    {
                        pam = pam + String.Format("pam_tally2 --user {0} --reset  && ", user);
                    }
                    commands.Add(pam.Substring(0, pam.Length-4));
                }
                else
                {
                    commands.Add(String.Format("printf '\\n'  &&  pam_tally2 --user {1} && printf '\\n'\r", parentHome, username, keyFile));
                }
                commands.Add("");








                    path = path.Replace("{", "").Replace("}", "").Replace(",","&");


                if(path.Length < 150) logWriter.createLogFile(path);


                var commandsEdited = commands.Select(s => s.Replace("//", "/")).ToList();

                foreach (var item in commandsEdited)
                    {
                        generatedCommand_tb.AppendText(item+"\n");



                        if (path.Length < 150) logWriter.Write(item, path);



                }

            }









        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void group_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void parentHome_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
