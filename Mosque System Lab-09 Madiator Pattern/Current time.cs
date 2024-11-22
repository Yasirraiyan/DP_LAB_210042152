public class CurrentTime : IWidget
{
    private IMediator _mediator;
    public void SetMediator(IMediator mediator)
    {
        _mediator = mediator;
    }
    public void Update()
    {
        Console.WriteLine("Current time is updated by time zone");
        _mediator.Notify();
    }
}
