namespace Prestamos.Modelos{
    public class Prestamo{

        public Prestamo(){}

        public int Id { get; set; }
        public int Id_Cliente { get; set; }
        public float Monto_Prestamo { get; set; }
        public datetime Fecha_Inicial { get; set; }
        public datetime Fecha_Corte { get; set; }
        public float Interes { get; set; }
        public int Meses_Prestamo { get; set; }
        public bool Completado { get; set; }


        public float PrestamoConIntereses(){
            return Monto_Prestamo+(Monto_Prestamo*Interes);
        }

        


    }
}