namespace PatronesComportamiento._8.Strategy.Context
{
    public class SistemaGestionTareas
    {
        public string mensaje { get; set; }

        private INotificationStrategy _notificationStrategy;

        public SistemaGestionTareas(INotificationStrategy notificationStrategy)
        {
            _notificationStrategy = notificationStrategy;
        }

        public void notificar()
        {
            mensaje = "MENSAJE POR DEFECTO SIST GEST TAREA";
            _notificationStrategy.enviarNoticacion(mensaje);
        }

        public void changeStrategy(INotificationStrategy newStrategy)
        {
            _notificationStrategy = newStrategy;
        }
    }
}