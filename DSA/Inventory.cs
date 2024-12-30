using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class Inventory
    {
        private String QuestionText;
        private String[] Options;
        private String AnswerKey;

        public Inventory(String questionnaire, String[] choices, String answer)
        {
            this.QuestionText = questionnaire;
            this.Options = choices;
            this.AnswerKey = answer;
        }

        public String getQuestion()
        {
            return QuestionText;
        }

        public String[] getOptions()
        {
            return Options;
        }

        public String getAnswer()
        {
            return AnswerKey;
        }

    }

    internal class Mathematics
    {
        public static Queue<Inventory> MathematicsQuestions()
        {
            Queue<Inventory> mathQuestions = new Queue<Inventory>();

            mathQuestions.Enqueue(new Inventory("What is the square root of 64?", new String[] { "6", "8", "10", "12" }, "B"));
            mathQuestions.Enqueue(new Inventory("Solve for x: 2x+5=15. What is the value of x?", new String[] { "5", "7", "10", "8" }, "A"));
            mathQuestions.Enqueue(new Inventory("Which shape has 6 sides?", new String[] { "Hexagon", "Octagon", "Decagon", "Heptagon" }, "A"));
            mathQuestions.Enqueue(new Inventory("What is the name of the mathematical constant approximately equal to 3.14159?", new String[] { "Euler's Number (e)", "Pi (π)", "Golden Ratio (ϕ)", "Sigma (σ)" }, "B"));
            mathQuestions.Enqueue(new Inventory("Which theorem states that in a right triangle,the square of the hypotenuse is equal to the sum of the squares of the other two sides?", new String[] { "Law of Cosines", "Fundamental Theorem of Calculus", "Binomial Theorem", "Pythagorean Theorem" }, "D"));
            mathQuestions.Enqueue(new Inventory("What is the perimeter of a rectangle with a length of 10 meters and a width of 5 meters?", new String[] { "15 meters", "30 meters", "20 meters", "50 meters" }, "B"));
            mathQuestions.Enqueue(new Inventory("If the area of a triangle is 36 square meters and its base is 12 meters, what is its height?", new String[] { "2 meters", "3 meters", "6 meters", "12 meters" }, "C"));
            mathQuestions.Enqueue(new Inventory("How many degrees are there in the sum of the interior angles of a triangle?", new String[] { "180", "360", "90", "270" }, "A"));
            mathQuestions.Enqueue(new Inventory("What is the term for the number sequence 1,1,2,3,5,8…  where each term is the sum of the previous two terms?", new String[] { "Arithmetic Sequence", "Geometric Sequence", "Fibonacci Sequence", "Pascal’s Triangle" }, "C"));
            mathQuestions.Enqueue(new Inventory("Which branch of mathematics deals with rates of change and slopes of curves?", new String[] { "Algebra", "Statistics", "Geometry", "Calculus" }, "D"));
            mathQuestions.Enqueue(new Inventory("What is the name of the process of finding the derivative of a function in calculus?", new String[] { "Integration", "Differentiation", "Exponentiation", "Factorization" }, "B"));
            mathQuestions.Enqueue(new Inventory("What is the concept of a limit in calculus?", new String[] { "The highest value a function reaches", "The slope of a curve", "The value a function approaches as input nears a point.", "A type of algebraic expression" }, "C"));
            mathQuestions.Enqueue(new Inventory("Which mathematician is known as the “Father of Geometry”?", new String[] { "Pythagoras", "Euclid", "Archimedes", "Newton" }, "B"));
            mathQuestions.Enqueue(new Inventory("Who is known for discovering the formula to find the area of a circle?", new String[] { "Galileo", "Newton", "Archimedes", "Pascal" }, "C"));
            mathQuestions.Enqueue(new Inventory("If you roll two six-sided dice, what is the probability of getting a sum of 7?", new String[] { "1/6", "1/12", "1/4", "1/8" }, "A"));


            return mathQuestions;
        }
    }
}
