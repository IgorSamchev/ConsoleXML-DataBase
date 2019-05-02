using System;

namespace Main
{
    internal class ObjectStore
    {
        private AppState _state = AppState.MainMenu;

        internal void Run()
        {
            /*
             * Write log, that program launched
             */
            LogManager.WriteLog(DateTime.Now.ToString("HH:mm:ss")
                                + " Starting objstore. Current Date: "
                                + DateTime.Now.ToString("dd.MM.yyyy"));

            /*
             * Change program state if user selected new state or close it
             */
            while (_state != AppState.Exit)
            {
                switch (_state)
                {
                    case AppState.MainMenu:
                        MainMenu();
                        break;
                    case AppState.ListData:
                        ListData();
                        break;
                    case AppState.Insert:
                        Insert();
                        break;
                    case AppState.Reset:
                        Reset();
                        break;
                    case AppState.Remove:
                        Remove();
                        break;
                    case AppState.Modify:
                        Modify();
                        break;
                    case AppState.Filter:
                        Filter();
                        break;
                    case AppState.Search:
                        Search();
                        break;
                    case AppState.Export:
                        Export();
                        break;
                    case AppState.Import:
                        Import();
                        break;
                    case AppState.HtmlExport:
                        HtmlExport();
                        break;
                    default:
                        _state = AppState.MainMenu;
                        break;
                }
            }
        }

        private void HtmlExport()
        {
            StudentToHtml.ExportToHtml();
            _state = AppState.MainMenu;
        }

        private void Import()
        {
            StudentImportCsv.Import();
            _state = AppState.MainMenu;
        }

        private void Export()
        {
            StudentToCsv.Export();
            _state = AppState.MainMenu;
        }

        private void Search()
        {
            StudentSearch.Search();
            _state = AppState.MainMenu;
        }

        private void Filter()
        {
            StudentFilters.Filters();
            _state = AppState.MainMenu;
        }

        private void Modify()
        {
            StudentModify.Modify();
            _state = AppState.MainMenu;
        }

        private void Remove()
        {
            StudentRemove.Remove();
            _state = AppState.MainMenu;
        }

        private void Reset()
        {
            StudentReset.Reset();
            _state = AppState.MainMenu;
        }

        private void Insert()
        {
            StudentInsert.Insert();
            _state = AppState.MainMenu;
        }

        private void ListData()
        {
            StudentList.ListData();
            _state = AppState.MainMenu;
        }

        /*
         * Main menu
         */
        private void MainMenu()
        {
            Console.WriteLine("Choose an operation: ");
            Console.WriteLine("1. List all Students");
            Console.WriteLine("2. Insert new Student");
            Console.WriteLine("3. Remove Student");
            Console.WriteLine("4. Change Student data");
            Console.WriteLine("5. Reset DataBase (ERASE ALL and initialize 4 basic Students)");
            Console.WriteLine("6. Filters menu");
            Console.WriteLine("7. Search by Field");
            Console.WriteLine("8. Export data to .CSV");
            Console.WriteLine("9. Import data from .CSV");
            Console.WriteLine("0. Export data to HTML table");
            Console.WriteLine("x. Exit");

            char key;
            do
            {
                Console.Write("Choice: ");
                key = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");

                switch (key)
                {
                    case '1':
                        _state = AppState.ListData;
                        break;
                    case '2':
                        _state = AppState.Insert;
                        break;
                    case '3':
                        _state = AppState.Remove;
                        break;
                    case '4':
                        _state = AppState.Modify;
                        break;
                    case '5':
                        _state = AppState.Reset;
                        break;
                    case '6':
                        _state = AppState.Filter;
                        break;
                    case '7':
                        _state = AppState.Search;
                        break;
                    case '8':
                        _state = AppState.Export;
                        break;
                    case '9':
                        _state = AppState.Import;
                        break;
                    case '0':
                        _state = AppState.HtmlExport;
                        break;
                    case 'x':

                        /*
                         * Write to log, that user closing program
                         */

                        LogManager.WriteLog(DateTime.Now.ToString("HH:mm:ss")
                                            + " Closing DataBase. Current Date: "
                                            + DateTime.Now.ToString("dd.MM.yyyy"));
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine($"Unknown operation '{key}'.");
                        break;
                }
            } while (key <= '0' && key >= '9');
        }
    }
}