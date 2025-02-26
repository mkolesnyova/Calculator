using OperationList;
namespace WindowsFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
                       
            OperationLibrary model = new OperationLibrary();
            FormsView view = new FormsView();
            FormsController controller = new FormsController(model, view);

            Application.Run(view);
        }
    }
}