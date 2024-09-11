using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adoproject
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            UpdateContent("In This course we divide the content into  5 units each unit contains 3 sub untis after you complete the content you can take you test");
        }
        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            
                UpdateContent("Content of Unit 1.2:\nProgramming Languages: These are formal languages comprising a set of instructions that produce various kinds of output." +
                    " \nCommon languages include Python, Java, C, and many others, each with its own syntax and use cases.\r\n\r\nSyntax: The set of rules that defines the" +
                    " \n combinations of symbols that are considered to be correctly structured programs in a language.");
            
        }

        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            UpdateContent("Content of Unit 1.3:\n Compilation and Interpretation: Some languages are compiled (converted into machine code), while others are interpreted" +
                "\n (executed line by line).\r\n\r\nVariables and Data Types: Variables are used to store data, which can be of various types, such as integers, floats, strings, etc..");
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {

            UpdateContent("1.1:\nProgramming is the process of designing and building an executable computer program to accomplish a specific computing" +
                "\n result or to perform a particular task. It's an essential skill in the field of computer science and technology, and it involves several key concepts " +
                "\nand practices. Here's an overview to get you started:A programming language is a formal language that specifies a set of instructions for a computer to " +
                "\nperform specific tasks. It’s used to write software programs and applications, and to control and manipulate computer systems. There are many different " +
                "\nprogramming languages, each with its own syntax, structure, and set of commands. Some of the most commonly used programming languages include Java, Python," +
                "\nC++, JavaScript, and C#. The choice of programming language depends on the specific requirements of a project, including the platform being used, the intended" +
                "\naudience, and the desired outcome. Programming languages continue to evolve and change over time, with new languages being developed and older ones being " +
                "\nupdated to meet changing needs.\r\n\r\nAre you aiming to become a software engineer one day? Do you also want to develop a mobile application that people all" +
                "\nover the world would love to use? Are you passionate enough to take the big step to enter the world of programming? Then you are in the right place because " +
                "\nthrough this article you will get a brief introduction to programming. Now before we understand what programming is, you must know what is a computer. A computer" +
                "\nis a device that can accept human instruction, processes it, and responds to it or a computer is a computational device that is used to process the data under" +
                "\nthe control of a computer program. Program is a sequence of instruction along with data. \r\n\r\nThe basic components of a computer are: \r\n\r\nInput unit\r\n" + "Central Processing Unit(CPU)\r\nOutput unit");
        }
        private void UpdateContent(string content)
        {
            // Clear existing content
            panel1.Controls.Clear();

            // Create a Label to display the new content
            Label contentLabel = new Label
            {
                Text = content,
                AutoSize = true,
                Location = new System.Drawing.Point(10, 10)
            };

            // Add the Label to the Panel
            panel1.Controls.Add(contentLabel);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            UpdateContent("Content of Unit 1.4:\nControl Structures\r\nConditionals: Statements like if, else if, and else are used to execute code based on certain conditions.\r\n\r\nLoops: These are used to execute a block of code repeatedly. Common loops include for, while, and do-while.");
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            UpdateContent("Content of Unit 1.5:\nFunctions: Blocks of code that perform a specific task, which can be reused and called multiple times within a program.\r\n\r\nParameters and Return Values: Functions often take inputs (parameters) and return outputs (return values).");
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            UpdateContent("Content of Unit 2.1:\nControl Structures\\r\\nConditionals: Statements like if, else if, and else are used to execute code based on certain conditions.\\r\\n\\r\\nLoops: These are used to execute a block of code repeatedly. Common loops include for, while, and do-while.\");\r\n      ");
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            UpdateContent("Content of Unit 2.2:\nFunctions: Blocks of code that perform a specific task, which can be reused and called multiple times within a program.\\r\\n\\r\\nParameters and Return Values: Functions often take inputs (parameters) and return outputs (return values).\");\r\n        ");
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            UpdateContent("Content of Unit 2.3:\nArrays: Collections of elements, typically of the same data type, stored in contiguous memory locations.\r\n\r\nLists, Sets, and Maps: More complex data structures that allow for more flexible storage and manipulation of data.");
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            UpdateContent("Content of Unit 2.4:\nThis section includes additional resources and summaries for Unit 1.3.");
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            UpdateContent("Content of Unit 2.5:\nThis section includes additional resources and summaries for Unit 1.3.");
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            UpdateContent("Content of Unit 3.1:\n Object-Oriented Programming (OOP)\r\nClasses and Objects: Classes define blueprints for objects, which are instances of classes.\r\n\r\nInheritance: Mechanism by which one class can inherit properties and methods from another.\r\n\r\nPolymorphism and Encapsulation: Concepts that allow for more flexible and secure code design.");
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            UpdateContent("Content of Unit 3.2:\n Debugging and Testing\r\nDebugging: The process of identifying and fixing errors or bugs in the code.\r\n\r\nTesting: Ensuring that code behaves as expected through various testing techniques like unit testing, integration testing, etc.");
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            UpdateContent("Content of Unit 3.3:\n Best Practices\r\nCode Readability: Writing clean and understandable code with proper naming conventions and comments.\r\n\r\nVersion Control: Using tools like Git to track changes and collaborate on code.");
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            UpdateContent("Content of Unit 3.4:\nThis section includes additional resources and summaries for Unit 1.3.");
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            UpdateContent("Content of Unit 3.5:\nThis section includes additional resources and summaries for Unit 1.3.");
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            UpdateContent("Content of Unit 4.1:\nLinked Lists: A collection of elements, where each element points to the next. Useful for dynamic memory allocation and when you need efficient insertion/deletion.\r\n\r\nTrees: Hierarchical data structures consisting of nodes. Common types include binary trees, binary search trees, and AVL trees. Trees are fundamental in algorithms like searching and sorting.");
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            UpdateContent("Content of Unit 4.2:\nGraphs: Consist of nodes (vertices) connected by edges. Used to model relationships and solve problems like network routing, social connections, and scheduling.\r\n\r\nHash Tables: Data structures that store key-value pairs, offering efficient retrieval based on keys. They are essential for implementing associative arrays and sets.");
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            UpdateContent("Content of Unit 4.3:\n Agile Methodology: A flexible, iterative approach to software development that focuses on delivering small, workable segments of software frequently.\r\n\r\nContinuous Integration and Continuous Deployment (CI/CD): Practices that involve automatically testing and integrating changes into a codebase, and deploying code to production environments. This ensures quicker releases and higher quality code.");
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            UpdateContent("Content of Unit 4.4:\nThis section includes additional resources and summaries for Unit 1.3.");
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            UpdateContent("Content of Unit 4.5:\nThis section includes additional resources and summaries for Unit 1.3.");
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            UpdateContent("Content of Unit 5.1:\nntegrated Development Environments (IDEs): Tools that provide comprehensive facilities for software development. Popular IDEs include Visual Studio, PyCharm, IntelliJ IDEA, and Eclipse.\r\n\r\nVersion Control Systems: Systems like Git that track changes to code and facilitate collaboration among developers. Platforms like GitHub, GitLab, and Bitbucket provide hosting and additional features for managing code repositories.");
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            UpdateContent("Content of Unit 5.2:\nMultithreading and Concurrency: Techniques for improving program performance by executing multiple threads or processes simultaneously. This is crucial for handling tasks like I/O operations, GUI applications, and parallel processing.\r\n\r\nMemory Management: Understanding how memory is allocated and managed in a program. This includes concepts like stack vs. heap allocation, garbage collection, and manual memory management.");
        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {

            UpdateContent("Content of Unit 5.3:\nOnline Tutorials and Courses: Websites like Codecademy, Coursera, Udemy, and edX offer courses ranging from beginner to advanced levels.\r\n\r\nCoding Challenges and Competitions: Platforms like LeetCode, HackerRank, and Codeforces provide practice problems and competitive programming opportunities.\r\n\r\nOpen Source Projects: Contributing to open source projects on platforms like GitHub can be a valuable way to gain practical experience and learn from real-world codebases.");

        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            UpdateContent("Content of Unit 5.1:\nThis section includes additional resources and summaries for Unit 1.3.");
        }

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {
            UpdateContent("Content of Unit 5.1:\nThis section includes additional resources and summaries for Unit 1.3.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f=new Form8();
            f.ShowDialog();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form8 f=new Form8();
            f.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form8 f = new Form8();
            f.ShowDialog();
            this.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form8 f = new Form8();
            f.ShowDialog();
            this.Close();
        }
    }
}
