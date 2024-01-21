using Admisiones.Logic;

var carrerOne = new CarrerPresential() { 
    Name="Desarrollo de Software",
    Description="Encargada del desarrollo",
    ValorSemestre=510.00m,
    TipoCarrera=TipoCarreras.Online,
};

var carrerDos = new CarrerPresential()
{
    Name = "Desarrollo de Aplicaciones Web",
    Description = "Encargada del desarrollo",
    ValorSemestre = 850.00m,
    TipoCarrera = TipoCarreras.Presencial,
};

var carrerTree = new CarrerPresential()
{
    Name = "Ventas",
    Description = "E",
    ValorSemestre = 510.00m,
    TipoCarrera = TipoCarreras.Online,
};

var carrerCua = new CarrerPresential()
{
    Name = "Administracion",
    Description = "A",
    ValorSemestre = 830.00m,
    TipoCarrera = TipoCarreras.Ejecutivo,
};

List<Carrer> carreras = new List<Carrer>() { carrerOne };
carreras.Add(carrerDos);
carreras.Add(carrerTree);
carreras.Add(carrerCua);

var carr_presen = carreras.FindAll(carr => carr.TipoCarrera == TipoCarreras.Ejecutivo);

//carreras.RemoveAll(carr => carr.Name == "Desarrollo de Aplicaciones Web");

foreach (var item in carr_presen)
{
    Console.WriteLine(item);
}

