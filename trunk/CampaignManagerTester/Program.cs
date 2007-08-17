using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignManagerTester
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        private static void MainMenu()
        {
            string choice = string.Empty;
            while (choice != "q")
            {
                switch (choice)
                {
                    case "c":
                        CharacterMenu();
                        break;
                    case "i":
                        ItemMenu();
                        break;
                    case "e":
                        EventMenu();
                        break;
                    case "l":
                        LocationMenu();
                        break;
                    case "s":
                        SpeciesMenu();
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Main Menu");
                Console.WriteLine("-----------------");
                Console.WriteLine("q: Quit");
                Console.WriteLine("c: Character Menu");
                Console.WriteLine("i: Item Menu");
                Console.WriteLine("e: Event Menu");
                Console.WriteLine("l: Location Menu");
                Console.WriteLine("s: species Menu");
                Console.WriteLine("-----------------");

                choice = Console.ReadLine();
            }
        }

        #region Characters

        private static void CharacterMenu()
        {
            string choice = string.Empty;
            while (choice != "q")
            {
                switch (choice)
                {
                    case "a":
                        Console.WriteLine("Add Character Selected");
                        break;
                    case "e":
                        Console.WriteLine("Edit Character Selected");
                        break;
                    case "d":
                        Console.WriteLine("Delete Character Selected");
                        break;
                    case "l":
                        Console.WriteLine("List Characters Selected");
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Character Menu");
                Console.WriteLine("-----------------");
                Console.WriteLine("q: Quit");
                Console.WriteLine("a: Add Character");
                Console.WriteLine("e: Edit Character");
                Console.WriteLine("d: Delete Character");
                Console.WriteLine("l: List Characters");
                Console.WriteLine("-----------------");

                choice = Console.ReadLine();
            }
        }

        #endregion

        #region Items

        private static void ItemMenu()
        {
            string choice = string.Empty;
            while (choice != "q")
            {
                switch (choice)
                {
                    case "a":
                        Console.WriteLine("Add Item Selected");
                        break;
                    case "e":
                        Console.WriteLine("Edit Item Selected");
                        break;
                    case "d":
                        Console.WriteLine("Delete Item Selected");
                        break;
                    case "l":
                        Console.WriteLine("List Items Selected");
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Item Menu");
                Console.WriteLine("-----------------");
                Console.WriteLine("q: Quit");
                Console.WriteLine("a: Add Item");
                Console.WriteLine("e: Edit Item");
                Console.WriteLine("d: Delete Item");
                Console.WriteLine("l: List Items");
                Console.WriteLine("-----------------");

                choice = Console.ReadLine();
            }
        }

        #endregion

        #region Event

        private static void EventMenu()
        {
            string choice = string.Empty;
            while (choice != "q")
            {
                switch (choice)
                {
                    case "a":
                        Console.WriteLine("Add Event Selected");
                        break;
                    case "e":
                        Console.WriteLine("Edit Event Selected");
                        break;
                    case "d":
                        Console.WriteLine("Delete Event Selected");
                        break;
                    case "l":
                        Console.WriteLine("List Events Selected");
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Event Menu");
                Console.WriteLine("-----------------");
                Console.WriteLine("q: Quit");
                Console.WriteLine("a: Add Event");
                Console.WriteLine("e: Edit Event");
                Console.WriteLine("d: Delete Event");
                Console.WriteLine("l: List Events");
                Console.WriteLine("-----------------");

                choice = Console.ReadLine();
            }
        }

        #endregion

        #region Location

        private static void LocationMenu()
        {
            string choice = string.Empty;
            while (choice != "q")
            {
                switch (choice)
                {
                    case "a":
                        Console.WriteLine("Add Location Selected");
                        break;
                    case "e":
                        Console.WriteLine("Edit Location Selected");
                        break;
                    case "d":
                        Console.WriteLine("Delete Location Selected");
                        break;
                    case "l":
                        Console.WriteLine("List Locations Selected");
                        break;
                    case "n":
                        EncounterMenu();
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Location Menu");
                Console.WriteLine("-----------------");
                Console.WriteLine("q: Quit");
                Console.WriteLine("a: Add Location");
                Console.WriteLine("e: Edit Location");
                Console.WriteLine("d: Delete Location");
                Console.WriteLine("l: List Locations");
                Console.WriteLine("n: Manage Location Encounters");
                Console.WriteLine("-----------------");

                choice = Console.ReadLine();
            }
        }

        #endregion

        #region Species

        private static void SpeciesMenu()
        {
            string choice = string.Empty;
            while (choice != "q")
            {
                switch (choice)
                {
                    case "a":
                        Console.WriteLine("Add Species Selected");
                        break;
                    case "e":
                        Console.WriteLine("Edit Species Selected");
                        break;
                    case "d":
                        Console.WriteLine("Delete Species Selected");
                        break;
                    case "l":
                        Console.WriteLine("List Species Selected");
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Species Menu");
                Console.WriteLine("-----------------");
                Console.WriteLine("q: Quit");
                Console.WriteLine("a: Add Species");
                Console.WriteLine("e: Edit Species");
                Console.WriteLine("d: Delete Species");
                Console.WriteLine("l: List Species");
                Console.WriteLine("-----------------");

                choice = Console.ReadLine();
            }
        }

        #endregion

        #region Encounter

        private static void EncounterMenu()
        {
            string choice = string.Empty;
            while (choice != "q")
            {
                switch (choice)
                {
                    case "a":
                        Console.WriteLine("Add Encounter Selected");
                        break;
                    case "g":
                        Console.WriteLine("Add Encounter Group Selected");
                        break;
                    case "e":
                        Console.WriteLine("Edit Encounter Selected");
                        break;
                    case "d":
                        Console.WriteLine("Delete Encounter Selected");
                        break;
                    case "l":
                        Console.WriteLine("List Encounter Selected");
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Encounter Menu");
                Console.WriteLine("-----------------");
                Console.WriteLine("q: Quit");
                Console.WriteLine("a: Add Encounter");
                Console.WriteLine("g: Add Encounter Group");
                Console.WriteLine("e: Edit Encounter");
                Console.WriteLine("d: Delete Encounter");
                Console.WriteLine("l: List Encounters");
                Console.WriteLine("-----------------");

                choice = Console.ReadLine();
            }
        }

        #endregion
    }
}
