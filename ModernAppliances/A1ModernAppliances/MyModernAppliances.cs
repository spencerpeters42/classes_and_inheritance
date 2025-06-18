﻿using System.Runtime.Serialization.Formatters;
using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: Spencer Peters</remarks>
    /// <remarks>Date: 6/17/2025 </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout()
        {
            // Write "Enter the item number of an appliance: "
            Console.WriteLine("Enter the item number of an appliance: ");
            // Create long variable to hold item number
            long item_num;
            // Get user input as string and assign to variable.
            String user_input = Console.ReadLine();
            // Convert user input from string to long and store as item number variable.
            item_num = long.Parse(user_input);
            // Create 'foundAppliance' variable to hold appliance with item number
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            Appliance? foundAppliance = null;
            // Loop through Appliances

            // Test appliance item number equals entered item number
            // Assign appliance in list to foundAppliance variable

            // Break out of loop (since we found what need to)
            foreach (var appliance in Appliances)
            {
                if (appliance.ItemNumber == item_num)
                {
                    foundAppliance = appliance;
                    break;
                }
            }
            // Test appliance was not found (foundAppliance is null)
         
            if(foundAppliance == null)
            {
                // Write "No appliances found with that item number."
                Console.WriteLine("No appliances found with that item number.");
            }
            // Otherwise (appliance was found)
            else
            {
                // Test found appliance is available
                if (foundAppliance.IsAvailable)
                {
                    // Checkout found appliance
                    foundAppliance.Checkout();
                    // Write "Appliance has been checked out."
                    Console.WriteLine("Appliance has been checked out.");
                }
                else
                // Otherwise (appliance isn't available)
                {
                    // Write "The appliance is not available to be checked out."
                    Console.WriteLine("The appliance is not available to be checked out.");
                }
            }               
        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"
            Console.WriteLine("Enter brand to search for: ");

            // Create string variable to hold entered brand
            // Get user input as string and assign to variable.
            String brand = Console.ReadLine();

            // Create list to hold found Appliance objects
            List<Appliance> foundAppliances = new List<Appliance>();
            // Iterate through loaded appliances
            foreach (var appliance in Appliances)
            {
                // Test current appliance brand matches what user entered
                if (appliance.Brand == brand)
                {
                    // Add current appliance in list to found list
                    foundAppliances.Add(appliance);
                }
            }
            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(foundAppliances, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options: ");
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "2 - Double doors"
            Console.WriteLine("2 - Double doors");
            // Write "3 - Three doors"
            Console.WriteLine("3 - Three doors");
            // Write "4 - Four doors"
            Console.WriteLine("4 - Four doors");
            // Write "Enter number of doors: "
            Console.WriteLine("Enter number of doors: ");
            // Create variable to hold entered number of doors
            // Get user input as string and assign to variable
            // Convert user input from string to int and store as number of doors variable.
            int num_doors = int.Parse(Console.ReadLine());

            // Create list to hold found Appliance objects
            List<Appliance> found = new List<Appliance>();

            // Iterate/loop through Appliances
            foreach (var appliance in Appliances)
            {
                // Test that current appliance is a refrigerator
                if (appliance is Refrigerator)
                {
                    // Down cast Appliance to Refrigerator
                    Refrigerator refrigerator = (Refrigerator)appliance;
                    // Test user entered 0 or refrigerator doors equals what user entered.
                    if (num_doors > 0 || num_doors == refrigerator.Doors)
                    {
                        // Add current appliance in list to found list
                        found.Add(appliance);
                    }
                }
            }

            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options: ");
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 - Residential"
            Console.WriteLine("1 - Residential");
            // Write "2 - Commercial"
            Console.WriteLine("2 - Commercial");
            // Write "Enter grade:"
            Console.WriteLine("Enter grade: ");
            // Get user input as string and assign to variable
            int user_input = int.Parse(Console.ReadLine());
            // Create grade variable to hold grade to find (Any, Residential, or Commercial)
            String? grade = null;
            // Test input is "0"
            if (user_input == 0)
            {
                // Assign "Any" to grade
                grade = "Any";
            }
            // Test input is "1"
            else if (user_input == 1)
            {
                // Assign "Residential" to grade
                grade = "Residential";
            
            }
            // Test input is "2"
            else if (user_input == 2)
            {
                // Assign "Commercial" to grade
                grade = "Commerical";
            }
            // Otherwise (input is something else)
            else
            {
                // Write "Invalid option."
                Console.WriteLine("Invalid option.");
                // Return to calling (previous) method
                // return;
                return;
            }

            // Write "Possible options:"
            Console.WriteLine("Possible options: ");
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 - 18 Volt"
            Console.WriteLine("1 - 18 Volt");
            // Write "2 - 24 Volt"
            Console.WriteLine("2 - 24 Volt");
            // Write "Enter voltage:"
            Console.WriteLine("Enter voltage");
            // Get user input as string
            int ui2 = int.Parse(Console.ReadLine());
            // Create variable to hold voltage
            int voltage = 0;
            // Test input is "0"
            if (ui2 == 0)
            {
                // Assign 0 to voltage
                voltage = 0;
            }
            // Test input is "1"
            else if (ui2 == 1)
            {
                // Assign 18 to voltage
                voltage = 18;
            }
            // Test input is "2"
            else if (ui2 == 2)
            {
                // Assign 24 to voltage
                voltage = 24;
            }
            // Otherwise
            else
            {
                // Write "Invalid option."
                Console.WriteLine("Invalid option.");
                // Return to calling (previous) method
                return;
            }
            // Create found variable to hold list of found appliances.
            List<Appliance> found = new List<Appliance>();
            // Loop through Appliances
            foreach (var appliance in Appliances)
            {
                // Check if current appliance is vacuum
                if (appliance is Vacuum)
                {
                    // Down cast current Appliance to Vacuum object
                    Vacuum vacuum = (Vacuum)appliance;
                    // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
                    if ((grade == "Any" || grade == vacuum.Grade) && (voltage == 0 || voltage == vacuum.BatteryVoltage))
                    {
                        // Add current appliance in list to found list
                        found.Add(vacuum);
                    }
                }
            }
            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 - Kitchen"
            Console.WriteLine("1 - Kitchen");
            // Write "2 - Work site"
            Console.WriteLine("2 - Work site");

            // Write "Enter room type:"
            Console.WriteLine("Enter room type: ");

            // Get user input as string and assign to variable
            int ui = int.Parse(Console.ReadLine());
            // Create character variable that holds room type
            char room_type = 'Z';
            // Test input is "0"
            if (ui == 0)
            {
                // Assign 'A' to room type variable
                room_type = 'A';
            }
            // Test input is "1"
            else if (ui == 1)
            {
                // Assign 'K' to room type variable
                room_type = 'K';
            } else if (ui == 2)
            // Test input is "2"
            {
                // Assign 'W' to room type variable
                room_type = 'W';
            }
            // Otherwise (input is something else)
            else
            {
                // Write "Invalid option."
                Console.WriteLine("Invalid option.");
                // Return to calling method
                return;
            }

            // Create variable that holds list of 'found' appliances
            List<Appliance> found = new List<Appliance>();
            // Loop through Appliances
            foreach (var appliance in Appliances)
            {
                // Test current appliance is Microwave
                if (appliance is Microwave)
                {
                    // Down cast Appliance to Microwave
                    Microwave microwave = (Microwave)appliance;
                    // Test room type equals 'A' or microwave room type
                    if (room_type == 'A' || room_type == microwave.RoomType)
                    {
                        // Add current appliance in list to found list
                        found.Add(microwave);
                    }
                }
            }
            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 - Quietest"
            Console.WriteLine("1 - Quietest");
            // Write "2 - Quieter"
            Console.WriteLine("2 - Quieter");
            // Write "3 - Quiet"
            Console.WriteLine("3 - Quiet");
            // Write "4 - Moderate"
            Console.WriteLine("4 - Moderate");

            // Write "Enter sound rating:"
            Console.WriteLine("Enter sound rating:");
            // Get user input as string and assign to variable
            int user_input = int.Parse(Console.ReadLine());
            // Create variable that holds sound rating
            String sound_rating = "";
            // Test input is "0"
            if (user_input == 0)
            {
                // Assign "Any" to sound rating variable
                sound_rating = "Any";
            }
            // Test input is "1"
            else if (user_input == 1)
            {
                // Assign "Qt" to sound rating variable
                sound_rating = "Qt";
            }
            // Test input is "2"
            else if (user_input == 2)
            {
                // Assign "Qr" to sound rating variable
                sound_rating = "Qr";
            }
            // Test input is "3"
            else if (user_input == 3)
            {
                // Assign "Qu" to sound rating variable
                sound_rating = "Qu";
            }
            // Test input is "4"
            else if (user_input == 4)
            {
                // Assign "M" to sound rating variable
                sound_rating = "M";
            }
            // Otherwise (input is something else)
            else
            {
                // Write "Invalid option."
                Console.WriteLine("Invalid option.");
                // Return to calling method
                return;
            }

            // Create variable that holds list of found appliances
            List<Appliance> found = new List<Appliance>();
            // Loop through Appliances
            foreach (var appliance in Appliances)
            {
                // Test if current appliance is dishwasher
                if (appliance is Dishwasher)
                {
                    // Down cast current Appliance to Dishwasher
                    Dishwasher dishwasher = (Dishwasher)appliance;

                    // Test sound rating is "Any" or equals soundrating for current dishwasher
                    if (sound_rating == "Any" || sound_rating == dishwasher.SoundRating)
                    {
                        // Add current appliance in list to found list
                        found.Add(dishwasher);
                    }
                }
            }
            // Display found appliances (up to max. number inputted)
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            // Write "Appliance Types"
            Console.WriteLine("Appliance Types");
            // Write "0 - Any"
            Console.WriteLine("0 - Any");
            // Write "1 – Refrigerators"
            Console.WriteLine("1 - Refridgerators");
            // Write "2 – Vacuums"
            Console.WriteLine("2 - Vacuums");
            // Write "3 – Microwaves"
            Console.WriteLine("3 - Microwaves");
            // Write "4 – Dishwashers"
            Console.WriteLine("4 - Dishwashers");

            // Write "Enter type of appliance:"
            Console.WriteLine("Enter type of appliance: ");

            // Get user input as string and assign to appliance type variable
            int user_input = int.Parse(Console.ReadLine());
            // Write "Enter number of appliances: "
            Console.WriteLine("Enter number of appliances: ");

            // Get user input as string and assign to variable
            int ui2 = int.Parse(Console.ReadLine());
            // Convert user input from string to int

            // Create variable to hold list of found appliances
            List<Appliance> found = new List<Appliance>();
            // Loop through appliances
            foreach (var appliance in Appliances)
            {
                // Test inputted appliance type is "0"
                if (user_input == 0)
                {
                    // Add current appliance in list to found list
                    found.Add(appliance);

                }// Test inputted appliance type is "1"
                else if (user_input == 1)
                {
                    // Test current appliance type is Refrigerator
                    if (appliance is Refrigerator)
                    {
                        // Add current appliance in list to found list
                        found.Add(appliance);
                    }
                    // Test inputted appliance type is "2"
                }
                else if (user_input == 2)
                {
                    // Test current appliance type is Vacuum
                    if (appliance is Vacuum)
                    {
                        // Add current appliance in list to found list
                        found.Add(appliance);
                    }
                    // Test inputted appliance type is "3"
                }
                else if (user_input == 3)
                {
                    // Test current appliance type is Microwave
                    if (appliance is Microwave)
                    {
                        // Add current appliance in list to found list
                        found.Add(appliance);
                    }
                // Test inputted appliance type is "4"
                }
                else if (user_input == 4)
                {
                    // Test current appliance type is Dishwasher
                    if (appliance is Dishwasher)
                    {
                        // Add current appliance in list to found list
                        found.Add(appliance);
                    }
                }
               
            }
            // Randomize list of found appliances
            found.Sort(new RandomComparer());

            // Display found appliances (up to max. number inputted)
            DisplayAppliancesFromList(found, ui2);
        }
    }
}
