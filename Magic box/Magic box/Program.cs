using System;

namespace Magic_box
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // magic box
            Console.WriteLine("Enter the number ");
            string Raw = Console.ReadLine();
            int row = int.Parse(Raw);

            int col = row;
            int cells = row * col;



            int row_t1 = 0
                , col_t1 = 0;

            row_t1 = (row / 2);
            col_t1 = (col / 2) + 1;


            Console.WriteLine("");for (int i = 1; i <= cells; i++)
            {
                    Console.SetCursorPosition((col_t1)*(120/(row+2)), (row_t1)*(30/ (row + 2)));
                    Console.WriteLine(i);

                    
                    int detect = i %col;


                    if (detect!=0) 
                    {
                        col_t1 = col_t1-1;
                        row_t1 = row_t1-1;

                        if(row_t1==0)
                        {
                            row_t1 = row;
                         
                        }
                        if (col_t1==0)
                        {
                            col_t1 = col;
                        }
                    }
                    else 
                    {
                        
                        row_t1 = row_t1 +1;
                    
                        
                    }



                
                    }
             
                



                
            }
        }
    }

