namespace Prestamos.Modelos{
    public class DetallesPrestamo{
        public DetallesPrestamo(){}
        public String Id_Prestamo { get; set; }
        public float Abono { get; set; }
        public datetime Fecha_Corte { get; set; }
        public int No_Abono { get; set; }
        public float SaldoAnterior { get; set; }
        public float SaldoDisponible { get; set; }
    }
}