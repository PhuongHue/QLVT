using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using QLVT.KetNoi;

namespace QLVT
{
    static class Program
    {
        public static KetNoiDB _ketNoiDB;

        public static FormLogin _formLogin;

        private static void InitForm()
        {
            _ketNoiDB = new KetNoiDB();
            _formLogin = new FormLogin();
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            InitForm();

            Application.Run(_formLogin);
            if (_ketNoiDB.Ready)
            {
                Application.Run(new FormMain());
            }
        }
    }
}
