using _06_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Console
{
    class ProgramUI
    {
        private StreamingContentRepository _contentRepo = new StreamingContentRepository();

        // Method that runs/starts the applicaation
        public void Run()
        {
            SeedContent();
            Menu();
        }
        // #MENU
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
               //Display our option to the user
                Console.WriteLine("Select a menu option: \n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Existing Content\n" +
                    "6. Exist");

                // Get the users input 
                string input = Console.ReadLine();

                //Evaluate the users input and act accordingly
                switch (input)
                {
                    case "1":
                        //Create new content
                        CreateNewContent();
                        break;
                    case "2":
                        // View All Content
                        DisplayAllContent();
                        break;
                    case "3":
                        // View Content by Title
                        DisplayContentByTitle();
                        break;
                    case "4":
                        // Update Existing Content
                        UpdateExistingContent();
                        break;
                    case "5":
                        // Delete Existing Content
                        DeleteExisitngContent();
                        break;
                    case "6":
                        // Exist
                        Console.WriteLine("Goodbye");
                        keepRunning = false;
                        break; 
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }

                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // #1 CREATE NEW StreamingContent
        private void CreateNewContent()
        {
            Console.Clear();
            StreamingContent newContent = new StreamingContent();

            //Title
            Console.WriteLine("Enter the Title for the Content");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the Description for the content");
            newContent.Description = Console.ReadLine();

            //Maturity Rating
            Console.WriteLine("Enter the rating for the content (G, PG, PG-13, etc):");
            newContent.MaturityRating = Console.ReadLine();

            //Star Rating
            Console.WriteLine("Enter the star count for the content 95.8, 10 1.5 etc):");
            string starsAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starsAsString);

            //IsFamilyFriendly
            Console.WriteLine("Is the content family friendly");
            string familyFriendlyString = Console.ReadLine().ToLower();

            if(familyFriendlyString == "y")
            {
                newContent.IsFamilyFriendly = true;
            }
            else
            {
                newContent.IsFamilyFriendly = false;
            }

            //GenreType
            Console.WriteLine("Enter the Genre Number:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. Scifi\n" +
                "4. Documentary\n" +
                "5. Bromance\n" +
                "6. Drama\n" +
                "7. Action");

            string genreAsString = Console.ReadLine();              // CASE == this is when we want to from a number int to a string 
            int genreAsInt = int.Parse(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            _contentRepo.AddContentToList(newContent);
        } 

        // #2 VIEW CURRENT StreamingContent that is saved
        private void DisplayAllContent()
        {
            Console.Clear();

            List<StreamingContent> listOfContent = _contentRepo.GetStreamingContents();

            foreach(StreamingContent content in listOfContent)
            {
                Console.WriteLine($"Title: {content.Title}, \n" +
                    $"Desc: {content.Description}");
            }
        }

        // #3 VIEW EXISTING Content by Title
        private void DisplayContentByTitle()
        {
            Console.Clear();
            //Prompt the user to give me a title
            Console.WriteLine("Enter the Title You Would Like to See");

            //Get the user's input
            string title = Console.ReadLine();

            //Find the content by that title
            StreamingContent content = _contentRepo.GetContentByTitle(title);

            //Display said content if it isn't null
            if(content != null)
            {
                Console.WriteLine($"Title: {content.Title}, \n" +
                    $"Description: {content.Description}\n" +
                    $"Maturity Rating: {content.MaturityRating}\n" +
                    $"Star: {content.StarRating}\n" + 
                    $"Is Family Friendly: {content.IsFamilyFriendly}\n" +
                    $"Genre: {content.TypeOfGenre}");
            }
            else
            {
                Console.WriteLine("No content by that Title");
            }
        }

        // #4 UPDATE EXISTING Content
        private void UpdateExistingContent()
        {
            //Display all content
            DisplayAllContent();

            //Ask for the title of the content
            Console.WriteLine("Enter the title of the content you'd like to update:");

            // Get that title
            string oldTitle = Console.ReadLine();

            // We will build a new object
            Console.Clear();
            StreamingContent newContent = new StreamingContent();


            //Title
            Console.WriteLine("Enter the Title for the Content");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the Description for the content");
            newContent.Description = Console.ReadLine();

            //Maturity Rating
            Console.WriteLine("Enter the rating for the content (G, PG, PG-13, etc):");
            newContent.MaturityRating = Console.ReadLine();

            //Star Rating
            Console.WriteLine("Enter the star count for the content 95.8, 10 1.5 etc):");
            string starsAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starsAsString);

            //IsFamilyFriendly
            Console.WriteLine("Is the content family friendly");
            string familyFriendlyString = Console.ReadLine().ToLower();         // ".ToLower" this allow the return to be in lowercase. ".ToUpper" allows for return to be uppercase

            if (familyFriendlyString == "y")
            {
                newContent.IsFamilyFriendly = true;
            }
            else
            {
                newContent.IsFamilyFriendly = false;
            }

            // EMUN: GenreType (fixed objects)
            Console.WriteLine("Enter the Genre Number:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. Scifi\n" +
                "4. Documentary\n" +
                "5. Bromance\n" +
                "6. Drama\n" +
                "7. Action");

            string genreAsString = Console.ReadLine();              // CASE == this is when we wnat to from a number int to a string 
            int genreAsInt = int.Parse(genreAsString);              // CASE
            newContent.TypeOfGenre = (GenreType)genreAsInt;         // CASE

            // Verification Input: Verify updated input from the user that the Update worked
            bool wasUpdated = _contentRepo.UpdateExistContent(oldTitle, newContent);

            if (wasUpdated)
            {
                Console.WriteLine("Content successfully updated!");
            }
            else
            {
                Console.WriteLine("Could not Update content.");
            }
        }

        // #5 DELETE EXISTING Content
        private void DeleteExisitngContent()
        {
            DisplayAllContent();


            //User Input: Get the object the use wants remove
            Console.WriteLine("Enter the title of the content you'd like to remove:");
            string input = Console.ReadLine();

            //Delete Method
            bool wasDeleted = _contentRepo.RemoveContentFromList(input);

            //If the content was deleted, say no
            if (wasDeleted)
            {
                Console.WriteLine("The content was successfully deleted.");
            }      
            else
            {
                Console.WriteLine("The content could not be deleted.");
            }
        } 

        // #5a DELETE EXISTING Content:EMPTY   // Otherwise state it could not be deleted
        private void DeleteExistingContent()
        {

        }

        // SEED METHOD==added static examples mainly used for filling out console output content
        private void SeedContent()
        {
            StreamingContent sharknado = new StreamingContent("SHarknado", "Tarndos, but with sharks.", "TV-!$", 3.3, true, GenreType.Action);
            StreamingContent theRoom = new StreamingContent("The Room", "Banker's life gets turned upside down.", "R", 3.7, false, GenreType.Documentary);
            StreamingContent rubber = new StreamingContent("Rubber", "Car tire comes to life and goes on killing spree.", "R", 5.8, false, GenreType.Documentary);

            _contentRepo.AddContentToList(sharknado);
            _contentRepo.AddContentToList(theRoom);
            _contentRepo.AddContentToList(rubber);

        }

    }
}
