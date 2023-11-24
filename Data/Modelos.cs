public class NaveEspacial
{
    public string id {get; set; } = Guid.NewGuid().ToString();
    public string Tipo { get; set; } = "";
    public string Marca { get; set; } = "";
    public string Raza { get; set; } = "";
    public string Tecnologia { get; set; } = "";
    public int CapacidadDeCarga { get; set; }
    public int CapacidadDePasajeros { get; set; }
    public double DistanciaEnAñosLuz { get; set; }

    public List<Pasajero> Pasajeros {get; set;} = new List<Pasajero>();
}


public class Pasajero{

    public Pasajero(){
        FechaNacimiento = DateOnly.Parse(DateTime.Now.ToString("dd/MM/yyyy"));
    }

    public string Cedula { get; set; } = "";
    public string Nombre { get; set; } = "";
    public string? Raza { get; set; }
    public DateOnly FechaNacimiento { get; set; }
    public string? Sexo { get; set; }

    public List<Objeto> Objetos {get; set;} = new List<Objeto>();
}

public enum EnumRadioactivo{
    Si,
    No
}

public class Objeto{
    public string Tipo {get; set;} = "";
    public string Nombre {get; set;} = "";
    public double Valor {get; set;}
    public EnumRadioactivo EsRadioactivo {get; set;} = EnumRadioactivo.No;
}
