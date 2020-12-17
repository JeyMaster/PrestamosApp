namespace Prestamos.Modelos{

    public class Cliente{

        public Cliente(){}

        public int Id { get; set; }
        public String Nombre { get; set; }
        public String ApellidoMaterno { get; set; }         
        public String ApellidoPaterno { get; set; }
        public float Credito { get; set; }  


        public bool CrearPrestamo(float prestamo){
            if(Credito>=prestamo){
                Credito-=prestamo;

                return true;
            }

            return false;
        }

        public void AbonarCredito(float abono, float monto_prestamo){
            
            if(Credito<monto_prestamo){
                Credito+=abono;
            }else{
                Credito=monto_prestamo;
            }
                
        }   
    }
}