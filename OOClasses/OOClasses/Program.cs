/* CSC10210 Assignment 1 Part 2, Test Program
 * Mathew Turner-Dauncey
 * 2017
 * Version 1.0
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //3 items of each type arrays
            Book[] bookCollection = new OOClasses.Book[3];
            int bookCollectionIndex = 0;
            Game[] gameCollection = new Game[3];
            int gameCollectionIndex = 0;
            OtherDigital[] otherDigitalCollection = new OtherDigital[3];
            int otherDigitalCollectionIndex = 0;

            //Intro
            Console.WriteLine("Welcome to Media Storage");

            //Integers for Menu Selection
            int actionInt = 1;
            int collectionInt;

            //While quit not selected, loop program
            while (actionInt != 0)
            {

                //Select User action, if 0 quit while loop to end program
                actionInt = StartMenu();
                if (actionInt == 0)
                    break;

                //If "Add" action selected
                if (actionInt == 1)
                {
                    //Get Collection option, Book, Game, or Other Digital
                    collectionInt = CollectionMenu();

                    //Add a book
                    if (collectionInt == 1 && bookCollectionIndex < 3)
                    {
                        Console.WriteLine("Enter Book Title");
                        string bookTitleTemp = Console.ReadLine();
                        Console.WriteLine("Enter Author");
                        string bookAuthorTemp = Console.ReadLine();
                        bookCollection[bookCollectionIndex] = new Book(bookTitleTemp, bookAuthorTemp);
                        bookCollectionIndex++;

                        Console.WriteLine("Book Added:" + bookCollection[bookCollectionIndex - 1].Title + " "
                            + bookCollection[bookCollectionIndex - 1].Author + "\n");
                        //RUN LIST
                    }

                    //Add a game
                    else if (collectionInt == 2 && gameCollectionIndex < 3)
                    {
                        Console.WriteLine("Enter Game Title");
                        string gameTitleTemp = Console.ReadLine();
                        Console.WriteLine("Enter Publisher");
                        string gamePublisherTemp = Console.ReadLine();
                        Console.WriteLine("Enter Version");
                        string gameVersionTemp = Console.ReadLine();
                        gameCollection[gameCollectionIndex] = new Game(gameTitleTemp, gamePublisherTemp, gameVersionTemp);
                        gameCollectionIndex++;

                        Console.WriteLine("Game Added:" + gameCollection[gameCollectionIndex - 1].Title + " "
                            + gameCollection[gameCollectionIndex - 1].Publisher + " " +
                            gameCollection[gameCollectionIndex - 1].Version + "\n");
                        //RUN LIST
                    }

                    //Add Other Digital
                    else if (collectionInt == 3 && otherDigitalCollectionIndex < 3)
                    {
                        Console.WriteLine("Enter Other Digital Title");
                        string otherDigitalTitleTemp = Console.ReadLine();
                        Console.WriteLine("Enter Additional Info");
                        string otherDigitalAdditionalInfoTemp = Console.ReadLine();
                        otherDigitalCollection[otherDigitalCollectionIndex] = new OtherDigital(otherDigitalTitleTemp,
                            otherDigitalAdditionalInfoTemp);
                        otherDigitalCollectionIndex++;

                        Console.WriteLine("Other Digital Added:" + otherDigitalCollection[otherDigitalCollectionIndex - 1].Title + " "
                            + otherDigitalCollection[otherDigitalCollectionIndex - 1].AdditionalInfo + "\n");
                        //RUN LIST
                    }
                    //If collection full or invalid menu option selected
                    else
                    {
                        Console.WriteLine("Error: Invalid Number Selection, or Collection may be Full");
                    }
                }

                //If "Change" is chosen
                if (actionInt == 2)
                {
                    //Get Collection option, Book, Game, or Other Digital
                    collectionInt = CollectionMenu();

                    //Edit Book
                    if (collectionInt == 1 && bookCollectionIndex > 0)
                    {
                        //Show List of Books
                        for (int i = 0; i < bookCollectionIndex; i++)
                        {
                            Console.WriteLine("[" + (i + 1) + "]=" + bookCollection[i].Title + " " +
                                bookCollection[i].Author);
                        }

                        //Get Index for Editing
                        Console.WriteLine("Which Number would you like to change?");
                        int bookIndex = int.Parse(Console.ReadLine());
                        Console.WriteLine("Edit: " + bookCollection[bookIndex - 1].Title + " " +
                            bookCollection[bookIndex - 1].Author);

                        //Get New Information
                        Console.WriteLine("Enter New Title:");
                        string newTitle = Console.ReadLine();
                        Console.WriteLine("Enter Author:");
                        string newAuthor = Console.ReadLine();

                        //Assign New Information
                        bookCollection[bookIndex - 1].Title = newTitle;
                        bookCollection[bookIndex - 1].Author = newAuthor;

                        //Display Result
                        Console.WriteLine("Book Edited to: " + bookCollection[bookIndex - 1].Title + " " +
                            bookCollection[bookIndex - 1].Author);
                    }
                    //Edit Game
                    else if (collectionInt == 2 && gameCollectionIndex > 0)
                    {
                        //Show List of Games
                        for (int i = 0; i < gameCollectionIndex; i++)
                        {
                            Console.WriteLine("[" + (i + 1) + "]=" + gameCollection[i].Title + " " +
                                gameCollection[i].Publisher + " " + gameCollection[i].Version);
                        }
                        Console.WriteLine("Which Number would you like to change?");

                        //Get index
                        int gameIndex = int.Parse(Console.ReadLine());
                        Console.WriteLine("Edit: " + gameCollection[gameIndex - 1].Title + " " +
                            gameCollection[gameIndex - 1].Publisher + " " + gameCollection[gameIndex - 1].Version);

                        //Get New Information
                        Console.WriteLine("Enter New Title:");
                        string newTitle = Console.ReadLine();
                        Console.WriteLine("Enter Publisher:");
                        string newPublisher = Console.ReadLine();
                        Console.WriteLine("Enter New Version");
                        string newVersion = Console.ReadLine();

                        //Assign new information
                        gameCollection[gameIndex - 1].Title = newTitle;
                        gameCollection[gameIndex - 1].Publisher = newPublisher;
                        gameCollection[gameIndex - 1].Version = newVersion;

                        //Display Result
                        Console.WriteLine("Game Edited to: " + gameCollection[gameIndex - 1].Title + " " +
                            gameCollection[gameIndex - 1].Publisher + " " + gameCollection[gameIndex - 1].Version);
                    }
                    //Edit Other Digital
                    else if (collectionInt == 3 && otherDigitalCollectionIndex > 0)
                    {
                        //Show List of Other Digital Items
                        for (int i = 0; i < otherDigitalCollectionIndex; i++)
                        {
                            Console.WriteLine("[" + (i + 1) + "]=" + otherDigitalCollection[i].Title + " " +
                                otherDigitalCollection[i].AdditionalInfo);
                        }
                        Console.WriteLine("Which Number would you like to change?");

                        //Get index
                        int otherDigitalIndex = int.Parse(Console.ReadLine());
                        Console.WriteLine("Edit: " + otherDigitalCollection[otherDigitalIndex - 1].Title + " " +
                            otherDigitalCollection[otherDigitalIndex - 1].AdditionalInfo);

                        //Get New Information
                        Console.WriteLine("Enter New Title:");
                        string newTitle = Console.ReadLine();
                        Console.WriteLine("Enter New Additional Info:");
                        string newAdditionalInfo = Console.ReadLine();

                        //Assign new information
                        otherDigitalCollection[otherDigitalIndex - 1].Title = newTitle;
                        otherDigitalCollection[otherDigitalIndex - 1].AdditionalInfo = newAdditionalInfo;

                        //Display Result
                        Console.WriteLine("Other Digital Edited to: " +
                            otherDigitalCollection[otherDigitalIndex - 1].Title + " " +
                            otherDigitalCollection[otherDigitalIndex - 1].AdditionalInfo);
                    }

                    //If incorrect selection or no data
                    else
                    {
                        Console.WriteLine("Error: Collection empty, or invalid number selected.");
                    }
                }

                //If Delete Selected
                if (actionInt == 3)
                {
                    collectionInt = CollectionMenu();
                    //Delete Book
                    if (collectionInt == 1 && bookCollectionIndex > 0)
                    {
                        //Show List of Books
                        for (int i = 0; i < bookCollectionIndex; i++)
                        {
                            Console.WriteLine("[" + (i + 1) + "]=" + bookCollection[i].Title + " " +
                                bookCollection[i].Author);
                        }
                        //Get Index
                        Console.WriteLine("Which Number would you like to delete?");
                        int bookIndex = int.Parse(Console.ReadLine());
                        //Remove Item information
                        Console.WriteLine(bookCollection[bookIndex - 1].Title + " " +
                            bookCollection[bookIndex - 1].Author + " has been removed");
                        bookCollection[bookIndex - 1].Title = "(empty).. select [2] to change";
                        bookCollection[bookIndex - 1].Author = "";

                    }

                    //Delete Game
                    else if (collectionInt == 2 && gameCollectionIndex > 0)
                    {
                        //Show List of Games
                        for (int i = 0; i < gameCollectionIndex; i++)
                        {
                            Console.WriteLine("[" + (i + 1) + "]=" + gameCollection[i].Title + " " +
                                gameCollection[i].Publisher + " " + gameCollection[i].Version);
                        }

                        //Get Index
                        Console.WriteLine("Which Number would you like to delete?");
                        int gameIndex = int.Parse(Console.ReadLine());
                        //Remove Item information
                        Console.WriteLine(gameCollection[gameIndex - 1].Title + " " +
                            gameCollection[gameIndex - 1].Publisher + " " +
                            gameCollection[gameIndex - 1].Version + " has been removed");
                        gameCollection[gameIndex - 1].Title = "(empty).. select [2] to change";
                        gameCollection[gameIndex - 1].Publisher = "";
                        gameCollection[gameIndex - 1].Version = "";

                    }

                    //Delete Other Digital
                    else if (collectionInt == 3 && otherDigitalCollectionIndex > 0)
                    {
                        //Show List of other digital
                        for (int i = 0; i < otherDigitalCollectionIndex; i++)
                        {
                            Console.WriteLine("[" + (i + 1) + "]=" + otherDigitalCollection[i].Title + " " +
                                otherDigitalCollection[i].AdditionalInfo);
                        }

                        //Get Index
                        Console.WriteLine("Which Number would you like to delete?");
                        int otherDigitalIndex = int.Parse(Console.ReadLine());
                        //Remove Item information
                        Console.WriteLine(otherDigitalCollection[otherDigitalIndex - 1].Title + " " +
                            otherDigitalCollection[otherDigitalIndex - 1].AdditionalInfo + " has been removed");
                        otherDigitalCollection[otherDigitalIndex - 1].Title = "(empty).. select [2] to change";
                        otherDigitalCollection[otherDigitalIndex - 1].AdditionalInfo = "";
                    }
                    //If no items present or invalid number selection
                    else
                    {
                        Console.WriteLine("Error: Collection may be empty, or invalid number selection.");
                    }
                }

                //If "Show List" is selected
                if (actionInt == 4)
                {
                    //Print All Book Items
                    Console.WriteLine("BOOKS:");
                    for (int i = 0; i < bookCollectionIndex; i++)
                    {
                        Console.WriteLine("[" + (i + 1) + "]" + bookCollection[i].Title + " " +
                            bookCollection[i].Author);
                    }
                    //Print All Game Items
                    Console.WriteLine("\nGAMES:");
                    for (int i = 0; i < gameCollectionIndex; i++)
                    {
                        Console.WriteLine("[" + (i + 1) + "]" + gameCollection[i].Title + " " +
                            gameCollection[i].Publisher + " " + gameCollection[i].Version);
                    }
                    //Print All Other Digital Items
                    Console.WriteLine("\nOTHER DIGITAL:");
                    for (int i = 0; i < otherDigitalCollectionIndex; i++)
                    {
                        Console.WriteLine("[" + (i + 1) + "]" + otherDigitalCollection[i].Title + " " +
                            otherDigitalCollection[i].AdditionalInfo);
                    }
                    Console.WriteLine("\n");
                }
            }


            //Press any key to close program after quitting
            Console.ReadKey();
        }

        //Function to display the Action Menu
        public static int StartMenu()
        {
            //Display Menu
            Console.WriteLine("Select Action using relative Number \n[1]=Add\n[2]=Change\n[3]=Delete\n" +
                "[4]=Show List\n[0]=Quit");
            int returnInt = 0;
            try
            {
                //Get Selection
                returnInt = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                StartMenu();
            }
            //Return Selection if Valid
            return returnInt;
        }

        //Function to display the Collection Menu
        public static int CollectionMenu()
        {
            //Display Menu
            Console.WriteLine("Select Type using relative Number \n[1]=Books\n[2]=Games\n[3]=Other Digital");
            int returnInt = 0;
            try
            {
                //Get Selection
                returnInt = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CollectionMenu();
            }
            //Return selection if valid
            return returnInt;
        }
    }


}