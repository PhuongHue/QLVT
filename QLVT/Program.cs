using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using QLVT.KetNoi;
using QLVT.QLVT_CN_DataSetTableAdapters;
using System.Data.SqlClient;
using QLVT.BatLoi;

namespace QLVT
{
    static class Program
    {
        public static KetNoiDB _ketNoiDB;

        public static FormLogin _formLogin;

        public static QLVT_CN_DataSet QLVT_CN_DataSet = new QLVT_CN_DataSet();

        public static TableAdapterManager TableAdapterManager = new TableAdapterManager();
        public static ChiNhanhTableAdapter ChiNhanhTableAdapter = new ChiNhanhTableAdapter();
        public static CTDDHTableAdapter CTDDHTableAdapter = new CTDDHTableAdapter();
        public static CTPNTableAdapter CTPNTableAdapter = new CTPNTableAdapter();
        public static CTPXTableAdapter CTPXTableAdapter = new CTPXTableAdapter();
        public static DatHangTableAdapter DatHangTableAdapter = new DatHangTableAdapter();
        public static KhoTableAdapter KhoTableAdapter = new KhoTableAdapter();
        public static NhanVienTableAdapter NhanVienTableAdapter = new NhanVienTableAdapter();
        public static PhieuNhapTableAdapter PhieuNhapTableAdapter = new PhieuNhapTableAdapter();
        public static PhieuXuatTableAdapter PhieuXuatTableAdapter = new PhieuXuatTableAdapter();
        public static VattuTableAdapter VattuTableAdapter = new VattuTableAdapter();

        public static void FillAllTable()
        {
            try
            {
                // fill tables
                ChiNhanhTableAdapter.Fill(QLVT_CN_DataSet.ChiNhanh);
                CTDDHTableAdapter.Fill(QLVT_CN_DataSet.CTDDH);
                CTPNTableAdapter.Fill(QLVT_CN_DataSet.CTPN);
                CTPXTableAdapter.Fill(QLVT_CN_DataSet.CTPX);
                DatHangTableAdapter.Fill(QLVT_CN_DataSet.DatHang);
                KhoTableAdapter.Fill(QLVT_CN_DataSet.Kho);
                NhanVienTableAdapter.Fill(QLVT_CN_DataSet.NhanVien);
                PhieuNhapTableAdapter.Fill(QLVT_CN_DataSet.PhieuNhap);
                VattuTableAdapter.Fill(QLVT_CN_DataSet.Vattu);
            }
            catch (SqlException e)
            {
                MessageBox.Show(SqlMessageResolver.SqlMessageResolve(e));
            }

        }

        public static void updateAll()
        {
            try
            {
                TableAdapterManager.UpdateAll(QLVT_CN_DataSet);
            }
            catch (SqlException e)
            {
                MessageBox.Show(SqlMessageResolver.SqlMessageResolve(e));
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void ChangeConnection(SqlConnection sqlConnection)
        {
            TableAdapterManager.Connection = sqlConnection;
            ChiNhanhTableAdapter.Connection = sqlConnection;
            CTDDHTableAdapter.Connection = sqlConnection;
            CTPNTableAdapter.Connection = sqlConnection;
            CTPXTableAdapter.Connection = sqlConnection;
            DatHangTableAdapter.Connection = sqlConnection;
            KhoTableAdapter.Connection = sqlConnection;
            NhanVienTableAdapter.Connection = sqlConnection;
            PhieuNhapTableAdapter.Connection = sqlConnection;
            VattuTableAdapter.Connection = sqlConnection;
        }

        private static void InitServices()
        {

            TableAdapterManager.ChiNhanhTableAdapter = ChiNhanhTableAdapter;
            TableAdapterManager.CTDDHTableAdapter = CTDDHTableAdapter;
            TableAdapterManager.CTPNTableAdapter = CTPNTableAdapter;
            TableAdapterManager.CTPXTableAdapter = CTPXTableAdapter;
            TableAdapterManager.DatHangTableAdapter = DatHangTableAdapter;
            TableAdapterManager.KhoTableAdapter = KhoTableAdapter;
            TableAdapterManager.NhanVienTableAdapter = NhanVienTableAdapter;
            TableAdapterManager.PhieuNhapTableAdapter = PhieuNhapTableAdapter;
            TableAdapterManager.PhieuXuatTableAdapter = PhieuXuatTableAdapter;
            TableAdapterManager.VattuTableAdapter = VattuTableAdapter;

            ChiNhanhTableAdapter.ClearBeforeFill = true;
            CTDDHTableAdapter.ClearBeforeFill = true;
            CTPNTableAdapter.ClearBeforeFill = true;
            CTPXTableAdapter.ClearBeforeFill = true;
            DatHangTableAdapter.ClearBeforeFill = true;
            KhoTableAdapter.ClearBeforeFill = true;
            NhanVienTableAdapter.ClearBeforeFill = true;
            PhieuNhapTableAdapter.ClearBeforeFill = true;
            VattuTableAdapter.ClearBeforeFill = true;

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
            //Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            InitServices();

            Application.Run(_formLogin);
            if (_ketNoiDB.Ready)
            {
                Application.Run(new FormMain());
            }
        }
    }
}
