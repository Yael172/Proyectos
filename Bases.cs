namespace Namespace {
    
    using System;
    
    public static class Module {
        
        public static object pi = 3.14;
        
        public static object opcion = input("¿Qué area desea Calcular? \n(c) Circulo \n(r) Rectángulo \n(t) triángulo \n(s) Salir");
        
        public static object vradio = Convert.ToInt32(input("Ingrese Radio"));
        
        public static object resultado = pi * (vradio * vradio);
        
        public static object vbase = Convert.ToInt32(input("Ingrese la Base"));
        
        public static object valtura = Convert.ToInt32(input("Ingrese la Altura"));
        
        public static object resultado = vbase * valtura;
        
        public static object vbase = Convert.ToInt32(input("Ingrese la Base"));
        
        public static object valtura = Convert.ToInt32(input("Ingrese la Altura"));
        
        public static object resultado = vbase * valtura / 2;
    }
}