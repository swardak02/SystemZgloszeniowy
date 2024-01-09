using System.ComponentModel.DataAnnotations;

public class ZgloszenieModel
{
    [Required(ErrorMessage = "Pole Tytuł jest wymagane.")]
    public string Tytul { get; set; }

    [Required(ErrorMessage = "Pole Opis jest wymagane.")]
    public string Opis { get; set; }

    [Required(ErrorMessage = "Proszę wybrać Typ zgłoszenia.")]
    public string Typ { get; set; } = "-"; 
}