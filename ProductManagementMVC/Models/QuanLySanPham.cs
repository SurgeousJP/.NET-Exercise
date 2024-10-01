namespace ProductManagementMVC.Models
{
    partial class QuanLySanPhamDataContext
    {
        public QuanLySanPhamDataContext() :
            base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QuanLySanPhamConnectionString"].ConnectionString, mappingSource)
        {
            OnCreated();
        }
    }
}