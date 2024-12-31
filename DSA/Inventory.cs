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
        private String SpareQuestionText;
        private String[] Options;
        private String[] SpareOptions;
        private String AnswerKey;
        private String SpareAnswerKey;

        public Inventory(String questionnaire,String spareQuestionnaire, String[] choices, String[] spareChoices, String answer, string spareAnswer)
        {
            this.QuestionText = questionnaire;
            this.SpareQuestionText = spareQuestionnaire;
            this.Options = choices;
            this.SpareOptions = spareChoices;
            this.AnswerKey = answer;
            this.SpareAnswerKey = spareAnswer;
        }

        public String getQuestion()
        {
            return QuestionText;
        }

        public String getSpareQuestion()
        {
            return SpareQuestionText;
        }

        public String[] getOptions()
        {
            return Options;
        }
        public String[] getSpareOptions()
        {
            return SpareOptions;
        }
        public String getAnswer()
        {
            return AnswerKey;
        }
        public String getSpareAnswer()
        {
            return SpareAnswerKey;
        }
    }

    internal class Mathematics
    {
        public static Queue<Inventory> MathematicsQuestions()
        {
            Queue<Inventory> mathQuestions = new Queue<Inventory>();

            mathQuestions.Enqueue(new Inventory("What is the square root of 64?", "If f(x) = x^2 - 2x + 1, what is f(1)?", new String[] { "6", "8", "10", "12" }, new String[] { "1", "-4", "0", "4" }, "B","C"));
            mathQuestions.Enqueue(new Inventory("Solve for x: 2x+5=15. What is the value of x?", "If f(x) = x^2 - 2x + 1, what is f(1)?", new String[] { "5", "7", "10", "8" }, new String[] { "1", "-4", "0", "4" }, "A" , "C"));
            mathQuestions.Enqueue(new Inventory("Which shape has 6 sides?", "If f(x) = x^2 - 2x + 1, what is f(1)?", new String[] { "Hexagon", "Octagon", "Decagon", "Heptagon" }, new String[] { "1", "-4", "0", "4" }, "A", "C"));
            mathQuestions.Enqueue(new Inventory("What is the name of the mathematical constant approximately equal to 3.14159?", "If f(x) = x^2 - 2x + 1, what is f(1)?", new String[] { "Euler's Number (e)", "Pi (π)", "Golden Ratio (ϕ)", "Sigma (σ)" }, new String[] { "1", "-4", "0", "4" }, "B", "C"));
            mathQuestions.Enqueue(new Inventory("Which theorem states that in a right triangle,the square of the hypotenuse is equal to the sum of the squares of the other two sides?", "If f(x) = x^2 - 2x + 1, what is f(1)?", new String[] { "Law of Cosines", "Fundamental Theorem of Calculus", "Binomial Theorem", "Pythagorean Theorem" }, new String[] { "1", "-4", "0", "4" }, "D", "C"));

            mathQuestions.Enqueue(new Inventory("What is the perimeter of a rectangle with a length of 10 meters and a width of 5 meters?", "What is the graph of y = 7x - 1?", new String[] { "15 meters", "30 meters", "20 meters", "50 meters" }, new String[] { "A Line", "A Circle", "A Parabola", "An Ellipse" }, "B", "A"));
            mathQuestions.Enqueue(new Inventory("If the area of a triangle is 36 square meters and its base is 12 meters, what is its height?", "What is the graph of y = 7x - 1?", new String[] { "2 meters", "3 meters", "6 meters", "12 meters" }, new String[] { "A Line", "A Circle", "A Parabola", "An Ellipse" }, "C", "A"));
            mathQuestions.Enqueue(new Inventory("How many degrees are there in the sum of the interior angles of a triangle?", "What is the graph of y = 7x - 1?", new String[] { "180", "360", "90", "270" }, new String[] { "A Line", "A Circle", "A Parabola", "An Ellipse" }, "A", "A"));
            mathQuestions.Enqueue(new Inventory("What is the term for the number sequence 1,1,2,3,5,8…  where each term is the sum of the previous two terms?", "What is the graph of y = 7x - 1?", new String[] { "Arithmetic Sequence", "Geometric Sequence", "Fibonacci Sequence", "Pascal’s Triangle" }, new String[] { "A Line", "A Circle", "A Parabola", "An Ellipse" }, "C", "A"));
            mathQuestions.Enqueue(new Inventory("Which branch of mathematics deals with rates of change and slopes of curves?", "What is the graph of y = 7x - 1?", new String[] { "Algebra", "Statistics", "Geometry", "Calculus" }, new String[] { "A Line", "A Circle", "A Parabola", "An Ellipse" }, "D", "A"));

            mathQuestions.Enqueue(new Inventory("What is the name of the process of finding the derivative of a function in calculus?", "How much interest is earned if $2500 is invested for 25 years at 8% simple interest?", new String[] { "Integration", "Differentiation", "Exponentiation", "Factorization" }, new String[] { "500", "50000", "2500", "5000" }, "B", "D"));
            mathQuestions.Enqueue(new Inventory("What is the concept of a limit in calculus?", "How much interest is earned if $2500 is invested for 25 years at 8% simple interest?", new String[] { "The highest value a function reaches", "The slope of a curve", "The value a function approaches as input nears a point.", "A type of algebraic expression" }, new String[] { "500", "50000", "2500", "5000" }, "C", "D"));
            mathQuestions.Enqueue(new Inventory("Which mathematician is known as the “Father of Geometry”?", "How much interest is earned if $2500 is invested for 25 years at 8% simple interest?", new String[] { "Pythagoras", "Euclid", "Archimedes", "Newton" }, new String[] { "500", "50000", "2500", "5000" }, "B", "D"));
            mathQuestions.Enqueue(new Inventory("Who is known for discovering the formula to find the area of a circle?", "How much interest is earned if $2500 is invested for 25 years at 8% simple interest?", new String[] { "Galileo", "Newton", "Archimedes", "Pascal" }, new String[] { "500", "50000", "2500", "5000" }, "C", "D"));
            mathQuestions.Enqueue(new Inventory("If you roll two six-sided dice, what is the probability of getting a sum of 7?", "How much interest is earned if $2500 is invested for 25 years at 8% simple interest?", new String[] { "1/6", "1/12", "1/4", "1/8" }, new String[] { "500", "50000", "2500", "5000" }, "A", "D"));


            return mathQuestions;
        }
    }

    internal class Science
    {
        public static Queue<Inventory> ScienceQuestions()
        {
            Queue<Inventory> scienceQuestions = new Queue<Inventory>();

            scienceQuestions.Enqueue(new Inventory("What is the water cycle?", "What is the primary function of a mammal's fur or hair?", new String[] { "A cycle of plant growth", "A cycle of water evaporation, condensation, and precipitation", "A cycle of animal migration", "A cycle of soil formation" }, new String[] { "To help them fly", "To provide insulation and regulate body temperature", "To help them swim", "To attract mates" }, "B", "B"));
            scienceQuestions.Enqueue(new Inventory("Why do leaves change color in the fall?", "What is the primary function of a mammal's fur or hair?", new String[] { "They lose water", "Chlorophyll breaks down and other pigments become visible", "They are dying", "They are absorbing more sunlight" }, new String[] { "To help them fly", "To provide insulation and regulate body temperature", "To help them swim", "To attract mates" }, "B", "B"));
            scienceQuestions.Enqueue(new Inventory("What are the three states of matter?", "What is the primary function of a mammal's fur or hair?", new String[] { "Solid, liquid, gas", "Solid, liquid, plasma", "Solid, gas, energy", "Solid, liquid, vapor" }, new String[] { "To help them fly", "To provide insulation and regulate body temperature", "To help them swim", "To attract mates" }, "A", "B"));
            scienceQuestions.Enqueue(new Inventory("How do plants make their food?", "What is the primary function of a mammal's fur or hair?", new String[] { "Through respiration", "Through digestion", "Through photosynthesis", "Through absorption" }, new String[] { "To help them fly", "To provide insulation and regulate body temperature", "To help them swim", "To attract mates" }, "C", "B"));
            scienceQuestions.Enqueue(new Inventory("The concept of gravity was discovered by which famous physicist?", "What is the primary function of a mammal's fur or hair?", new String[] { "Albert Einstein", "Galileo Galilei", "Sir Isaac Newton", "Nikola Tesla" }, new String[] { "To help them fly", "To provide insulation and regulate body temperature", "To help them swim", "To attract mates" }, "C", "B"));

            scienceQuestions.Enqueue(new Inventory("What is the study of mushrooms called?", "What is the significance of the asteroid belt?", new String[] { "Botany", "Zoology", "Mycology", "Geology" }, new String[] { "It is where most comets originate", "It contains the largest planets", "It is a region of dark matter", "It separates the inner and outer planets in our solar system" }, "C","D"));
            scienceQuestions.Enqueue(new Inventory("Which freezes faster, hot water or cold water?", "What is the significance of the asteroid belt?", new String[] { "Hot water", "Cold water", "They freeze at the same time", "It depends on the container" }, new String[] { "It is where most comets originate", "It contains the largest planets", "It is a region of dark matter", "It separates the inner and outer planets in our solar system" }, "A", "D"));
            scienceQuestions.Enqueue(new Inventory("How does fat leave your body when you lose weight?", "What is the significance of the asteroid belt?", new String[] { "Sweat only", "Urine only", "C.It converts to muscle ", "Sweat, urine, and breath" }, new String[] { "It is where most comets originate", "It contains the largest planets", "It is a region of dark matter", "It separates the inner and outer planets in our solar system" }, "D", "D"));
            scienceQuestions.Enqueue(new Inventory("From which body part does the majority of your body heat escape?", "What is the significance of the asteroid belt?", new String[] { "Head", "Hands", "Feet", "Evenly throughout the body" }, new String[] { "It is where most comets originate", "It contains the largest planets", "It is a region of dark matter", "It separates the inner and outer planets in our solar system" }, "D", "D"));
            scienceQuestions.Enqueue(new Inventory("The science that deals with the properties, changes and interactions of matter and energy.", "What is the significance of the asteroid belt?", new String[] { "Chemistry", "Physics", "Biology", "Geology" }, new String[] { "It is where most comets originate", "It contains the largest planets", "It is a region of dark matter", "It separates the inner and outer planets in our solar system" }, "B", "D"));

            scienceQuestions.Enqueue(new Inventory("The branch of biology that deals with the relations between living organisms and their environment.", "What is the heaviest naturally occurring element used as nuclear fuel?", new String[] { "Ecology", "Botany", "Anatomy", "Mathematics" }, new String[] { "Uranium", "Plutonium", "Thorium", "Radium" }, "A", "A"));
            scienceQuestions.Enqueue(new Inventory("Which organ system makes hormones that control your growth, moods, and behavior?", "What is the heaviest naturally occurring element used as nuclear fuel?", new String[] { "Nervous", "Circulatory", "Endocrine", "Integumentary" }, new String[] { "Uranium", "Plutonium", "Thorium", "Radium" }, "C", "A"));
            scienceQuestions.Enqueue(new Inventory("What is a test that figures out how hard your heart is pumping to move blood all over your body called?", "What is the heaviest naturally occurring element used as nuclear fuel?", new String[] { "Blood Pressure Test", "Biopsy", "Electrocardiogram", "Cat Scan" }, new String[] { "Uranium", "Plutonium", "Thorium", "Radium" }, "A", "A"));
            scienceQuestions.Enqueue(new Inventory("What is the cell structure that collects extra water from the cytoplasm and expels it from the cell?", "What is the heaviest naturally occurring element used as nuclear fuel?", new String[] { "Contractile Vacuole", "Binary Fission", "Cyloplasm", "Respiration" }, new String[] { "Uranium", "Plutonium", "Thorium", "Radium" }, "A", "A"));
            scienceQuestions.Enqueue(new Inventory("Which organ system makes white blood cells to help fight disease?", "What is the heaviest naturally occurring element used as nuclear fuel?", new String[] { "Integumentary", "What is the heaviest naturally occurring element used as nuclear fuel?", "Lymphatic", "Circulatory", "Respiratory" }, new String[] { "Uranium", "Plutonium", "Thorium", "Radium" }, "B", "A"));

            return scienceQuestions;
        }
    }

    internal class History
    {
        public static Queue<Inventory> HistoryQuestions()
        {
            Queue<Inventory> historyQuestions = new Queue<Inventory>();

            historyQuestions.Enqueue(new Inventory("Who is known as the national hero of the Philippines, whose novels sparked the flames of revolution?", "In what year did the Philippines gain independence from the United States?", new String[] { "José Rizal", "Andres Bonifacio", "Emilio Aguinaldo", "Apolinario Mabini" }, new String[] { "1898", "1935", "1946", "1965" }, "A", "C"));
            historyQuestions.Enqueue(new Inventory("Which Filipino leader declared independence from Spain on June 12, 1898?", "In what year did the Philippines gain independence from the United States?", new String[] { "Andres Bonifacio", "Emilio Aguinaldo", "José Rizal", "Manuel L. Quezon" }, new String[] { "1898", "1935", "1946", "1965" }, "B", "C"));
            historyQuestions.Enqueue(new Inventory("What was the ancient script used by early Filipinos before Spanish colonization?", "In what year did the Philippines gain independence from the United States?", new String[] { "Alibata", "Baybayin", "Kawi", "Sanskrit" }, new String[] { "1898", "1935", "1946", "1965" }, "B", "C"));
            historyQuestions.Enqueue(new Inventory("Which battle in 1521 marked the first recorded resistance of Filipinos against foreign invaders?", "In what year did the Philippines gain independence from the United States?", new String[] { "Battle of Mactan", "Battle of Manila", "Battle of Cebu", "Battle of Paete" }, new String[] { "1898", "1935", "1946", "1965" }, "A", "C"));
            historyQuestions.Enqueue(new Inventory("Who was the first female president of the Philippines, known for restoring democracy after the Marcos regime?", "In what year did the Philippines gain independence from the United States?", new String[] { "Gloria Macapagal-Arroyo", "Imelda Marcos", "Corazon Aquino", "Miriam Defensor Santiago" }, new String[] { "1898", "1935", "1946", "1965" }, "C", "C"));

            historyQuestions.Enqueue(new Inventory("What was the name of the General that led the capture of Emilio Aguinaldo in 1901?", "Which ancient wonder was located in the city of Babylon?", new String[] { "Freedom", "Liberation", "Eagle", "Funston" }, new String[] { "Great Pyramid of Giza", "Hanging Gardens", "Colossus of Rhodes", "Temple of Artemis" }, "D", "B"));
            historyQuestions.Enqueue(new Inventory("Which Filipino general led the most decorated unit of defense of Bataan against Japanese forces in World War II?", "Which ancient wonder was located in the city of Babylon?", new String[] { "General Vicente Lim", "General Antonio Luna", "General Gregorio del Pilar", "General Artemio Ricarte" }, new String[] { "Great Pyramid of Giza", "Hanging Gardens", "Colossus of Rhodes", "Temple of Artemis" }, "A", "B"));
            historyQuestions.Enqueue(new Inventory("Which treaty ended the Spanish-American War, leading to the cession of the Philippines to the United States?", "Which ancient wonder was located in the city of Babylon?", new String[] { "Treaty of Versailles", "Treaty of Paris 1898", "Treaty of Tordesillas", "Peace of Westphalia" }, new String[] { "Great Pyramid of Giza", "Hanging Gardens", "Colossus of Rhodes", "Temple of Artemis" }, "B", "B"));
            historyQuestions.Enqueue(new Inventory("Who was the Filipino revolutionary leader known as the 'Brains of the Katipunan'?", "Which ancient wonder was located in the city of Babylon?", new String[] { "Emilio Jacinto", "Apolinario Mabini", "Andress Bonifacio", "José Rizal" }, new String[] { "Great Pyramid of Giza", "Hanging Gardens", "Colossus of Rhodes", "Temple of Artemis" }, "A", "B"));
            historyQuestions.Enqueue(new Inventory("What is the official language of the Philippines alongside Filipino?", "Which ancient wonder was located in the city of Babylon?", new String[] { "Spanish", "Tagalog", "Cebuano", "English" }, new String[] { "Great Pyramid of Giza", "Hanging Gardens", "Colossus of Rhodes", "Temple of Artemis" }, "D", "B"));

            historyQuestions.Enqueue(new Inventory("Which island was ceded to the U.S. together with the Philippines in the Treaty of Paris?", "In what year did the Philippine Revolution, led by Emilio Aguinaldo, officially begin?", new String[] { "Guam", "Palau", "Borneo", "Hawaii" }, new String[] { "1892", "1896", "1898", "1901" }, "A", "B"));
            historyQuestions.Enqueue(new Inventory("Who is known as the 'Sublime Paralytic' of the Philippine Revolution?", "In what year did the Philippine Revolution, led by Emilio Aguinaldo, officially begin?", new String[] { "Marcelo H. del Pilar", "Apolinario Mabini", "Emilio Aguinaldo", "Andres Bonifacio" }, new String[] { "1892", "1896", "1898", "1901" }, "B", "B"));
            historyQuestions.Enqueue(new Inventory("What was the first European country to colonize the Philippines?", "In what year did the Philippine Revolution, led by Emilio Aguinaldo, officially begin?", new String[] { "Portugal", "France", "Spain", "Netherlands" }, new String[] { "1892", "1896", "1898", "1901" }, "C", "B"));
            historyQuestions.Enqueue(new Inventory("Where was the site of the famous 'Cry of Pugad Lawin' that started the Philippine Revolution?", "In what year did the Philippine Revolution, led by Emilio Aguinaldo, officially begin?", new String[] { "Cavite", "Balintawak", "Tarlac", "Batangas" }, new String[] { "1892", "1896", "1898", "1901" }, "B", "B"));
            historyQuestions.Enqueue(new Inventory("What was the name of the secret society that initiated the Philippine Revolution against Spanish rule in 1896?", "In what year did the Philippine Revolution, led by Emilio Aguinaldo, officially begin?", new String[] { "La Solidaridad", "La Liga Filipina", "Katipunan", "Propaganda Movement" }, new String[] { "1892", "1896", "1898", "1901" }, "C", "B"));

            return historyQuestions;
        }
    }
}
