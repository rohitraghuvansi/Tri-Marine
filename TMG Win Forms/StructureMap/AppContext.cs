using System.Windows.Forms;
using StructureMap;
using TMGPIS;

namespace TMG.WinForms
{
	public class AppContext : ApplicationContext
	{		
		private IContainer Container { get; set; }
		public AppContext(IContainer container)
		{
			Container = container;
			MainForm = GetMainForm();
		}
		private Form GetMainForm()
		{
            //MainForm mainForm = new MainForm(Container);

            //Container.Inject<IOrgChartView>(mainForm);
            //OrgChartPresenter presenter = Container.GetInstance<OrgChartPresenter>();
            //presenter.Run();

		    return new TMGPIS.frmLogIn();
		}
	}
}