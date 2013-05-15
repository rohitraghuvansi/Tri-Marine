using System.Windows.Forms;
using TMG.EventAggregator;
using StructureMap.Configuration.DSL;

namespace TMG.WinForms
{
	public class DefaultRegistry : Registry
	{
		public DefaultRegistry()
		{
            For<ApplicationContext>().Use<AppContext>();
            For<IApplicationController>().Use<ApplicationController>();
            ForSingletonOf<IEventPublisher>().Use<EventPublisher>();
            //ForRequestedType<IOrgChartView>()
            //     .TheDefaultIsConcreteType<MainForm>()
            //     .OnCreation((i, v) => i.GetInstance<EmployeeDetailPresenter>());
            //For<IEmployeeRepository>().Use<InMemoryEmployeeRepository>();
            //For<IEmployeeDetailView>().Use<ViewEmployeeDetailControl>();
            //For<ICommand<AddNewEmployeeData>>().Use<AddNewEmployeeService>();
            //For<IGetNewEmployeeInfo>().Use<NewEmployeeInfoPresenter>();
            //For<INewEmployeeInfoView>().Use<NewEmployeeInfoForm>();
            //For<IGetEmployeeManager>().Use<SelectEmployeeManagerPresenter>();
            //For<ISelectEmployeeManagerView>().Use<SelectEmployeeManagerForm>();			
			RegisterInterceptor(new EventAggregatorInterceptor());
		}

	}

}