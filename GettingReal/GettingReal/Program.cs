namespace GettingReal
{
    public class Program
    {
        static List<Booking> bookings = new List<Booking>();
        static void Main(string[] args)
        {
            void CreateBooking()
            {
                //Navn (påkrævet)
                string name;
                while (true)
                {
                    Console.WriteLine("Indstast navn: ");
                    name = Console.ReadLine();

                    if (string.IsNullOrEmpty(name))
                    {
                        Console.WriteLine("Navn er påkærvet! Prøv igen.");
                    }
                    else
                    {
                        break;
                    }
                }

                //Telefonnummer (påkrævet)
                string phoneNumber;
                while (true)
                {
                    Console.WriteLine("Indtast telefonnummer: ");
                    phoneNumber = Console.ReadLine();

                    if (string.IsNullOrEmpty(phoneNumber))
                    {
                        Console.WriteLine("Telefonnummer er påkrævet! Prøv igen.");
                    }

                    else
                    {
                        break;
                    }
                }

                //Dato + tid
                DateTime dateTime;
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Indstast dato og tid  (yyyy-MM-dd HH:mm): ");
                        dateTime = DateTime.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Ugyldigt format! Prøv igen.");
                    }
                }

                //Antal gæster
                int guest;
                while (true)
                {
                    Console.WriteLine("Antal gæster: ");

                    if (int.TryParse(Console.ReadLine(), out guest))
                    {

                        if (guest > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Antal gæster skal være over 0!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ugyldigt tal! Prøv igen.");
                    }
                }


                //Anledning (valgfri)
                Console.WriteLine("Anledning (valgfri - tryk ENTER for at springe over): ");
                string occasion = Console.ReadLine();

                if (!string.IsNullOrEmpty(occasion))
                {
                    occasion = null;
                }

                //Opret booking
                Booking booking = new Booking(name, phoneNumber, dateTime, guest, occasion);
                bookings.Add(booking);

                Console.WriteLine("Booking oprettet!");
            }
        }
    }
}
