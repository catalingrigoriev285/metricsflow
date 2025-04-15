using Models;
using DatabaseManagement.FileSystem;

namespace EvaluationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Role> roles = new List<Role>();
            List<User> users = new List<User>();
            List<Evaluation> evaluations = new List<Evaluation>();

            UserInterface data = new UserInterface();

            int? selected_option = null;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Evaluation System!");
                Console.WriteLine("1. Create Role");
                Console.WriteLine("2. Create User");
                Console.WriteLine("3. Create Evaluation");

                Console.WriteLine("4. Display all roles");
                Console.WriteLine("5. Display all users");
                Console.WriteLine("6. Display all evaluations");

                Console.WriteLine("7. Save to file roles");
                Console.WriteLine("8. Save to file users");
                Console.WriteLine("9. Save to file evaluations");

                Console.WriteLine("10. Exit");

                Console.Write("Please select an option: ");

                string input = Console.ReadLine();
                if (int.TryParse(input, out int option))
                {
                    selected_option = option;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.ReadKey();
                    continue;
                }

                switch (selected_option)
                {
                    case 1:
                        Console.Write("Enter role name: ");
                        string roleName = Console.ReadLine();
                        Console.Write("Enter role description: ");
                        string roleDescription = Console.ReadLine();
                        
                        Role tempRole = new Role(roleName, roleDescription);
                        roles.Add(tempRole);

                        Console.WriteLine($"Role '{roleName}' created successfully.");

                        break;

                    case 2:
                        Console.Write("Enter user name: ");
                        string userName = Console.ReadLine();
                        Console.Write("Enter user prename: ");
                        string userPrename = Console.ReadLine();
                        Console.Write("Enter user email: ");
                        string userEmail = Console.ReadLine();

                        Console.Write("Enter role id: ");
                        int roleId = int.Parse(Console.ReadLine());
                        Role selectedRole = roles.FirstOrDefault(r => r.id == roleId);

                        if (selectedRole != null)
                        {
                            User tempUser = new User(userName, userPrename, userEmail, selectedRole);
                            users.Add(tempUser);
                            Console.WriteLine($"User '{userName} {userPrename}' created successfully.");
                        }
                        else
                        {
                            Console.WriteLine($"Role with id {roleId} not found.");
                        }
                        break;

                    case 3:
                        Console.Write("Enter evaluation title: ");
                        string evalTitle = Console.ReadLine();
                        Console.Write("Enter evaluation description: ");
                        string evalDescription = Console.ReadLine();
                        Evaluation tempEval = new Evaluation(evalTitle, evalDescription);
                        evaluations.Add(tempEval);
                        Console.WriteLine($"Evaluation '{evalTitle}' created successfully.");

                        Console.Write("Enter number of questions: ");
                        int questionCount = int.Parse(Console.ReadLine());

                        for (int i = 0; i < questionCount; i++)
                        {
                            Console.Write("Enter question text: ");
                            string questionText = Console.ReadLine();
                            Console.Write("Enter question description: ");
                            string questionDescription = Console.ReadLine();

                            Console.Write("Enter number of answers: ");
                            int answerCount = int.Parse(Console.ReadLine());

                            List<Question.Answer> answers = new List<Question.Answer>();

                            for (int j = 0; j < answerCount; j++)
                            {
                                Console.Write("Enter answer value: ");
                                string answerValue = Console.ReadLine();
                                Console.Write("Is this answer valid? (true/false): ");
                                bool isValid = bool.Parse(Console.ReadLine());
                                Question.Answer tempAnswer = new Question.Answer(answerValue, isValid);
                                answers.Add(tempAnswer);
                            }

                            Question tempQuestion = new Question(questionText, questionDescription, answers);
                            tempEval.AddQuestion(tempQuestion);
                        }

                        break;

                    case 4:
                        if (roles.Count == 0)
                        {
                            Console.WriteLine("No roles found.");
                            break;
                        }

                        Console.WriteLine("Roles:");
                        foreach (var role in roles)
                        {
                            Console.WriteLine(role);
                        }
                        break;

                    case 5:
                        users.AddRange(data.loadUsers());

                        if (users.Count == 0)
                        {
                            Console.WriteLine("No users found.");
                            break;
                        }

                        Console.WriteLine("Users:");
                        foreach (var user in users)
                        {
                            Console.WriteLine(user);
                        }
                        break;

                    case 6:
                        if (evaluations.Count == 0)
                        {
                            Console.WriteLine("No evaluations found.");
                            break;
                        }

                        Console.WriteLine("Evaluations:");

                        foreach (var evaluation in evaluations)
                        {
                            Console.WriteLine(evaluation);
                            foreach (var question in evaluation.questions)
                            {
                                Console.WriteLine($"  {question}");
                                foreach (var answer in question.answers)
                                {
                                    Console.WriteLine($"    {answer}");
                                }
                            }
                        }

                        break;

                    case 7:
                        break;
                    case 8:
                        foreach (var user in users)
                        {
                            data.saveUser(user);
                            Console.WriteLine($"User '{user.name} {user.prename}' saved to file.");
                        }
                        break;
                    case 9:
                        break;

                    case 10:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}