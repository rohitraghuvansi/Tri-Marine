namespace TMG.EventAggregator
{
	public interface IEventHandler<T>
	{
		void Handle(T eventData);
	}
}