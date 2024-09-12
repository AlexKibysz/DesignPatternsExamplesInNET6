namespace PatronesEstructurales
{
    /*	Supongamos que estamos desarrollando un sistema de envío de mensajes
     *	para una aplicación de chat. Queremos que los usuarios puedan enviar
     *	mensajes a través de diferentes canales, como SMS, correo electrónico
     *	y notificaciones push. Además, queremos que los usuarios puedan elegir
     *	entre diferentes proveedores de servicios de mensajería, como Twilio,
     *	SendGrid o Firebase Cloud Messaging (FCM).
*/

    public class Bridge
    {
        public abstract class Mensajeria
        {
            protected IServiceMSGProvider _serviceMSGProvider;

            public Mensajeria(IServiceMSGProvider serviceMSGProvider)
            {
                this._serviceMSGProvider = serviceMSGProvider;
            }

            public abstract void EnviarMensaje(string mensaje);

            //una vez definida la abstraccion vamos a definir la abstraccion extendidas
        }
        public class Email : Mensajeria
        {
            public Email(IServiceMSGProvider serviceMsgProvider) : base(serviceMsgProvider)
            {
            }

            public override void EnviarMensaje(string mensaje)
            {
                Console.WriteLine($"Email enviado: {mensaje}");
                base._serviceMSGProvider.OnServiceMSG(mensaje);
            }
        }

        public class SMS : Mensajeria
        {
            public SMS(IServiceMSGProvider serviceMsgProvider) : base(serviceMsgProvider)
            {
            }

            public override void EnviarMensaje(string mensaje)
            {
                Console.WriteLine($"SMS enviado: {mensaje}");
                base._serviceMSGProvider.OnServiceMSG(mensaje);
            }
        }

        public class NotifPush : Mensajeria
        {
            public NotifPush(IServiceMSGProvider serviceMsgProvider) : base(serviceMsgProvider)
            {
            }

            public override void EnviarMensaje(string mensaje)
            {
                Console.WriteLine($"NotifPush enviado: {mensaje}");
                base._serviceMSGProvider.OnServiceMSG(mensaje);
            }
        }



        //Aca hacemos las implementaciones
        //Twilio, SendGrid o Firebase Cloud Messaging (FCM)

        public interface IServiceMSGProvider
        {
            void OnServiceMSG(string msg);
        }

        public class Twilo : IServiceMSGProvider
        {
            public void OnServiceMSG(string msg)
            {
                Console.WriteLine($"Enviado desde Twilo:  {msg}");
            }
        }

        public class SendGrid : IServiceMSGProvider
        {
            public void OnServiceMSG(string msg)
            {
                Console.WriteLine($"Enviado desde sendgrid:  {msg}");
            }
        }

        public class FirebaseCloudMessaging : IServiceMSGProvider
        {
            public void OnServiceMSG(string msg)
            {
                Console.WriteLine($"Enviado desde FirebaseCloudMsg:  {msg}");
            }
        }
    }
}
    /*

            using Microsoft.VisualBasic;
            using PatronesEstructurales;
            using System.ComponentModel.DataAnnotations;
            using static PatronesEstructurales.Bridge.Mensajeria;

            var twilo = new Twilo();

            var sendGrid = new SendGrid();

            var FCM = new FirebaseCloudMessaging();

            var email = new Email(sendGrid);

            email.EnviarMensaje("Hola mundo estoy enviando este desde sendgrid y email para este ejemplo");

            var msg = new SMS(twilo);

            msg.EnviarMensaje("estoy enviando este msg desde twilo y ahora voy a mandar otro msg desde otro lado");

            var msgFCM = new SMS(FCM);

            msgFCM.EnviarMensaje("ahora envio este msg desde Firebase");

     */
