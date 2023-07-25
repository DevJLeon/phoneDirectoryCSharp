using System;
using System.Collections;

class Program {
    static void Main() {
        int opcion;

        ArrayList contactList = new ArrayList();

        do {
            ShowOption();
            opcion = RequestOption();

            switch (opcion) {
                case 1:
                    writeSpace();
                    //AddContact();
                    break;
                case 2:
                    writeSpace();
                    //ShowContacts();
                    break;
                case 3:
                    writeSpace();
                    //MarkFavContact();
                    break;
                case 4:
                    writeSpace();
                    //deleteContact();
                    break;
                case 5:
                    writeSpace();
                    Console.WriteLine("Hasta luego.");
                    break;
                default:
                    writeSpace();
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }

            Console.WriteLine();
        } while (opcion != 4);
    }

    static void ShowOption() {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Add contact");
        Console.WriteLine("2. Display all contacts");
        Console.WriteLine("3. Mark as favourite");
        Console.WriteLine("4. Delete contact");
        Console.WriteLine("5. Salir");
    }

    static int RequestOption() {
        Console.Write("Elige una opción: ");
        return Convert.ToInt32(Console.ReadLine());
    }
    
    static void AddContact(){
        ArrayList contactArray = new ArrayList();
        Console.WriteLine("Contact Name: ");
        string contactName = Console.ReadLine();

        Console.WriteLine("Contact Phone number: ");
        int phoneNumber = int.Parse(Console.ReadLine());

        contactArray.Add(contactName);
        contactArray.Add(phoneNumber);

        contactList.Add(contactArray);
    }
