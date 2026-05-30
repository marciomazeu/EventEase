namespace EventEase.Services
{
    public class EventStateService
    {
        // Rastreia a quantidade total de inscrições feitas na sessão atual
        public int TotalRegistrations { get; private set; } = 0;

        public void IncrementRegistrations()
        {
            TotalRegistrations++;
        }
    }
}