using CSharpFundamentals.Core.Models.FilehandlingAndJson;
using System.Text.Json;

namespace CSharpFundamentals
{
    public static class Day18_FileHandlingAnd_JSONSerialization
    {

        /*
         
         // 2. Creamos una instancia de la clase
        var product = new Product
        {
            Id = 1,
            Name = "Laptop",
            Price = 1200.50m
        };

        // 3. Serializamos el objeto a un string JSON
        string jsonString = JsonSerializer.Serialize(product);
        Console.WriteLine($"Serialized JSON: {jsonString}");

        // 4. Escribimos el string JSON en un archivo
        string filePath = "product.json";
        File.WriteAllText(filePath, jsonString);
        Console.WriteLine($"File created at: {filePath}");

        // 5. Leemos el string JSON desde el archivo
        string jsonFromFile = File.ReadAllText(filePath);
        Console.WriteLine($"JSON read from file: {jsonFromFile}");

        // 6. Deserializamos el string JSON de vuelta a un objeto
        Product restoredProduct = JsonSerializer.Deserialize<Product>(jsonFromFile);
        Console.WriteLine($"Restored Product: Id={restoredProduct.Id}, Name={restoredProduct.Name}, Price={restoredProduct.Price}");
         */



        public static void ExecuteTODOlIST()
        {
            string filePath = "task.json";
            List<TaskExercise> tasks;
            string userChoice;


            if (File.Exists(filePath))
            {
                string jsonFromFile = File.ReadAllText(filePath);
                tasks = JsonSerializer.Deserialize<List<TaskExercise>>(jsonFromFile);
                Console.WriteLine(" ✅ Task loaded successfully.");
            }
            else
            {
                tasks = new List<TaskExercise>();
                Console.WriteLine("No existing tasks file found. Starting with an empty list.");
            }

            do
            {
                Console.WriteLine("\n--- Main Menu ---");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. List Task");
                Console.WriteLine("3. Mark Task as Completed");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice: ");
                userChoice = Console.ReadLine();

                if (int.TryParse(userChoice, out int intUserChoice))
                {
                    switch (intUserChoice)
                    {
                        case 1:
                            Console.WriteLine("Enter the new task's description");
                            string inputDescription = Console.ReadLine();
                            int nextId = tasks.Any() ? tasks.Max(t => t.Id) + 1 : 1;

                            TaskExercise newTask = new TaskExercise
                            {
                                Id = nextId,
                                Description = inputDescription,
                                IsCompleted = true
                            };
                            tasks.Add(newTask);
                            Console.WriteLine($"Task with ID {nextId} added successfully");
                            break;
                        case 2:
                            Console.WriteLine("---- Your To-Do List ----");
                            if (tasks.Count == 0)
                            {
                                Console.WriteLine("The task list is empty.");
                            }
                            else
                            {
                                foreach (var task in tasks)
                                {
                                    string status = task.IsCompleted ? "[COMPLETED]" : "[PENDING]";
                                    Console.WriteLine($"ID: {task.Id} | {status} | Description: {task.Description}");
                                }
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter the ID of the task to mark  as completed");
                            if (int.TryParse(Console.ReadLine(), out int taskId))
                            {
                                TaskExercise taskToUpdate = tasks.FirstOrDefault(t => t.Id == taskId);

                                if (taskToUpdate != null)
                                {
                                    taskToUpdate.IsCompleted = true;
                                    Console.WriteLine($"Task with ID{taskId} marked as completed");
                                }
                                else
                                {
                                    Console.WriteLine($"Error: No task found with ID {taskId}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid ID.");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Exiting program...");
                            break;
                        default:
                            Console.WriteLine("Invalid option.Please try again");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Error : Please enter a number");
                }

            } while (userChoice != "4");


            string jsonString = JsonSerializer.Serialize(tasks);
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine("Task saved successfully");
        }

        public static void ExecuteApplicationConfiguration()
        {
            string pathFile = "appsettings.json";
            string userChoice;

            AppSettings appSettings;

            if (File.Exists(pathFile))
            {
                string jsonFromFile = File.ReadAllText(pathFile);
                appSettings = JsonSerializer.Deserialize<AppSettings>(jsonFromFile);
                Console.WriteLine("AppSettings  loaded successfully");
            }
            else
            {
                appSettings = new AppSettings
                {
                    ApiUrl = "https://default.api/v1",
                    RetryCount = 3,
                    IsEnabled = true,
                };

                Console.WriteLine("File not found.Creating defaul settings...");
            }


            do
            {

                Console.WriteLine("\n--- Current AppSettings ---");
                Console.WriteLine($"1. ApiUrl: {appSettings.ApiUrl}");
                Console.WriteLine($"2. RetryCount: {appSettings.RetryCount}");
                Console.WriteLine($"3. IsEnabled: {appSettings.IsEnabled}");
                Console.WriteLine($"4. Done and Save");
                Console.Write("Enter the number of the setting you want to change, or 4 to save and exit: ");
                userChoice = Console.ReadLine();
                if (int.TryParse(userChoice, out int intUserChoice))
                {
                    switch (intUserChoice)
                    {
                        case 1:
                            Console.Write("Enter new ApiUrl: ");
                            appSettings.ApiUrl = Console.ReadLine();
                            Console.WriteLine("Url updated. Will be saved on exit.");
                            break;

                        case 2:
                            Console.Write("Enter new RetryCount: ");
                            
                            if (int.TryParse(Console.ReadLine(), out int intRetryCount))
                            {
                                appSettings.RetryCount = intRetryCount;
                                Console.WriteLine("RetryCount updated. Will be saved on exit.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a number.");
                            }
                            break;

                        case 3:
                            Console.Write("Enter new IsEnabled (true/false): ");
                            string inputEnabled = Console.ReadLine().ToLower();

                            if (inputEnabled == "true" || inputEnabled == "yes")
                            {
                                appSettings.IsEnabled = true;
                                Console.WriteLine("IsEnabled updated. Will be saved on exit.");
                            }
                            else if (inputEnabled == "false" || inputEnabled == "no")
                            {
                                appSettings.IsEnabled = false;
                                Console.WriteLine("IsEnabled updated. Will be saved on exit.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter 'true' or 'false'.");
                            }
                            break;

                        case 4:
                            Console.WriteLine("Exiting program...");
                            break;

                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;




                    }
                }


            } while (userChoice != "4");



            string jsonString = JsonSerializer.Serialize<AppSettings>(appSettings);
            File.WriteAllText("appsettings.json", jsonString);

            Console.WriteLine("\nSettings saved successfully");

            Console.WriteLine($"Api url :  {appSettings.ApiUrl}");
            Console.WriteLine($"Retry Count: {appSettings.RetryCount}");
            Console.WriteLine($"Is Enabled: {appSettings.IsEnabled}");
        }
    }
}
