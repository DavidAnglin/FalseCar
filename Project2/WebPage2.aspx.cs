using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project2
{
    public partial class WebPage2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string FName = (string)(Session["FName"]);            
            string LName = (string)(Session["LName"]);
            string Color = (string)(Session["Color"]);
            string Married = (string)(Session["Married"]);
            string Children = (string)(Session["Children"]);
            string Income = (string)(Session["Income"]);
            string Gender = (string)(Session["Gender"]);




            YourCar(FName, LName, Color, Married, Children, Income, Gender);
        }

        protected void YourCar(string FName, string LName, string Color, string Married, string Children, string Income, string Gender)
        { 
                if (Married == "Yes" & Income == "<$50,000")
                {
                    if (Children == "Yes")
                    {
                        if (Gender == "Male")
                        {
                            if (Color == "Black")
                            {
                                lblCar1.Text = "Black Ford Fusion";
                                img1.ImageUrl = "/Images/blackfusion.jpg";
                                lblCar2.Text = "Black Honda Pilot";
                                img2.ImageUrl = "/Images/blackpilot.jpe";
                            }
                            else if (Color == "White")
                            {
                                lblCar1.Text = "White Ford Fusion";
                                img1.ImageUrl = "/Images/whitefushion.jpe";
                                lblCar2.Text = "White Honda Pilot";
                                img2.ImageUrl = "/Images/whitepilot.jpg";
                            }
                        }  
                        else if (Gender == "Female")
                        {
                            if (Color == "Black")
                            {
                                lblCar1.Text = "Black Chevy Tahoe";
                                img1.ImageUrl = "/Images/blacktahoe.jpe";
                                lblCar2.Text = "Black Honda Civic";
                                img2.ImageUrl = "/Images/blackcivic.jpe";
                            }
                            else if (Color == "White")
                            {
                                lblCar1.Text = "White Chevy Tahoe";
                                img1.ImageUrl = "/Images/whitetahoe.jpe";
                                lblCar2.Text = "White Honda Civic";
                                img2.ImageUrl = "/Images/whitecivic.jpg";
                            }
                        }
                    }
                    else if (Children == "No")
                    {
                        if (Gender == "Male")
                        {
                            if (Color == "Black")
                            {
                                lblCar1.Text = "Black Toyota Highlander";
                                img1.ImageUrl = "/Images/blackhighlander.jpe";
                                lblCar2.Text = "Black Chevy Cruze";
                                img2.ImageUrl = "/Images/blackcruze.jpe";
                            }
                            else if (Color == "White")
                            {
                                lblCar1.Text = "White Toyota Highlander";
                                img1.ImageUrl = "/Images/whitehighlander.jpe";
                                lblCar2.Text = "White Chevy Cruze";
                                img2.ImageUrl = "/Images/whitecruze.jpe";
                            }
                        }  
                        else if (Gender == "Female")
                        {
                            if (Color == "Black")
                            {
                                lblCar1.Text = "Black Toyota Camry";
                                img1.ImageUrl = "/Images/blackcamry.jpg";
                                lblCar2.Text = "Black Ford Escape";
                                img2.ImageUrl = "/Images/blackescape.jpg";
                            }
                            else if (Color == "White")
                            {
                                lblCar1.Text = "White Toyota Camry";
                                img1.ImageUrl = "/Images/whitecamry.jpe";
                                lblCar2.Text = "White Ford Escape";
                                img2.ImageUrl = "/Images/whiteescape.jpg";
                            }
                        }
                    }
              }
              else if (Married == "Yes" & Income == ">$50,000")
              {
                    if (Children == "Yes")
                    {
                        if (Gender == "Male")
                        {
                            if (Color == "Black")
                            {
                                lblCar1.Text = "Black Chevy Camaro";
                                img1.ImageUrl = "/Images/blackcamaro.jpe";
                                lblCar2.Text = "Black Ford F-150";
                                img2.ImageUrl = "/Images/blackF150.jpe";
                            }
                            else if (Color == "White")
                            {
                                lblCar1.Text = "White Chevy Camaro";
                                img1.ImageUrl = "/Images/whitecamaro.jpe";
                                lblCar2.Text = "White Ford F-150";
                                img2.ImageUrl = "/Images/whiteF150.jpe";
                            }
                        }
                        else if (Gender == "Female")
                        {
                            if (Color == "Black")
                            {
                                lblCar1.Text = "Black Toyota Tundra";
                                img1.ImageUrl = "/Images/blacktundra.jpg";
                                lblCar2.Text = "Black Honda Civic";
                                img2.ImageUrl = "/Images/blackcivic.jpe";
                            }
                            else if (Color == "White")
                            {
                                lblCar1.Text = "White Toyota Tundra";
                                img1.ImageUrl = "/Images/whitetundra.jpe";
                                lblCar2.Text = "White Honda Civic";
                                img2.ImageUrl = "/Images/whitecivic.jpg";
                            }
                        }
                    }
                    else if (Children == "No")
                    {
                        if (Gender == "Male")
                        {
                            if (Color == "Black")
                            {
                                lblCar1.Text = "Black Honda Accord";
                                img1.ImageUrl = "/Images/blackaccord.jpg";
                                lblCar2.Text = "Black Toyota Celica";
                                img2.ImageUrl = "/Images/blackcelica.jpe";
                            }
                            else if (Color == "White")
                            {
                                lblCar1.Text = "White Honda Accord";
                                img1.ImageUrl = "/Images/whiteaccord.jpe";
                                lblCar2.Text = "White Toyota Celica";
                                img2.ImageUrl = "/Images/whitecelica.jpe";
                            }
                        }
                        else if (Gender == "Female")
                        {
                            if (Color == "Black")
                            {
                                lblCar1.Text = "Black Chevy Silverado";
                                img1.ImageUrl = "/Images/blacksilverado.jpe";
                                lblCar2.Text = "Black Ford Escape";
                                img2.ImageUrl = "/Images/blackescape.jpg";
                            }
                            else if (Color == "White")
                            {
                                lblCar1.Text = "White Chevy Silverado";
                                img1.ImageUrl = "/Images/whitesilverado.jpe";
                                lblCar2.Text = "White Ford Escape";
                                img2.ImageUrl = "/Images/whiteescape.jpg";
                            }
                        }
                    }
                }
                else if (Married == "No" & Income == "<$50,000")
                {
                    if (Children == "Yes")
                    {
                        if (Gender == "Male")
                        {
                            if (Color == "Black")
                            {
                                lblCar1.Text = "Black Ford Fusion";
                                img1.ImageUrl = "/Images/blackfusion.jpg";
                                lblCar2.Text = "Black Ford Mustang";
                                img2.ImageUrl = "/Images/blackmustang.jpe";
                            }
                            else if (Color == "White")
                            {
                                lblCar1.Text = "White Ford Fusion";
                                img1.ImageUrl = "/Images/whitefushion.jpe";
                                lblCar2.Text = "White Ford Mustang";
                                img2.ImageUrl = "/Images/whitemustang.jpe";
                            }
                        }
                        else if (Gender == "Female")
                        {
                            if (Color == "Black")
                            {
                                lblCar1.Text = "Black Toyota Camry";
                                img1.ImageUrl = "/Images/blackcamry.jpg";
                                lblCar2.Text = "Black Toyota Highlander";
                                img2.ImageUrl = "/Images/blackhighlander.jpe";
                            }
                            else if (Color == "White")
                            {
                                lblCar1.Text = "White Chevy Tahoe";
                                img1.ImageUrl = "/Images/whitetahoe.jpe";
                                lblCar2.Text = "White Toyota Highlander";
                                img2.ImageUrl = "/Images/whitehighlander.jpe";
                            }
                        }
                    }
                    else if (Children == "No")
                    {
                        if (Gender == "Male")
                        {
                            if (Color == "Black")
                            {
                                lblCar1.Text = "Black Ford Mustang";
                                img1.ImageUrl = "/Images/blackmustang.jpe";
                                lblCar2.Text = "Black Honda Ridgeline";
                                img2.ImageUrl = "/Images/blackridgeline.jpg";
                            }
                            else if (Color == "White")
                            {
                                lblCar1.Text = "White Ford Mustang";
                                img1.ImageUrl = "/Images/whitemustang.jpe";
                                lblCar2.Text = "White Honda Ridgeline";
                                img2.ImageUrl = "/Images/whiteridgeline.jpeg";
                            }
                        }
                        else if (Gender == "Female")
                        {
                            if (Color == "Black")
                            {
                                lblCar1.Text = "Black Toyota Camry";
                                img1.ImageUrl = "/Images/blackcamry.jpg";
                                lblCar2.Text = "Black Ford Escape";
                                img2.ImageUrl = "/Images/blackescape.jpg";
                            }
                            else if (Color == "White")
                            {
                                lblCar1.Text = "White Toyota Camry";
                                img1.ImageUrl = "/Images/whitecamry.jpe";
                                lblCar2.Text = "White Ford Escape";
                                img2.ImageUrl = "/Images/whiteescape.jpg";
                            }
                        }
                    }
                }
                else if (Married == "No" & Income == ">$50,000")
                {
                    if (Children == "Yes")
                    {
                        if (Gender == "Male")
                        {
                            if (Color == "Black")
                            {
                                lblCar1.Text = "Black Chevy Tahoe";
                                img1.ImageUrl = "/Images/blacktahoe.jpe";
                                lblCar2.Text = "Black Honda Pilot";
                                img2.ImageUrl = "/Images/blackpilot.jpe";
                            }
                            else if (Color == "White")
                            {
                                lblCar1.Text = "White Chevy Tahoe";
                                img1.ImageUrl = "/Images/whitetahoe.jpe";
                                lblCar2.Text = "White Honda Pilot";
                                img2.ImageUrl = "/Images/whitepilot.jpg";
                            }
                        }
                        else if (Gender == "Female")
                        {
                            if (Color == "Black")
                            {
                                lblCar1.Text = "Black Chevy Camaro";
                                img1.ImageUrl = "/Images/blackcamaro.jpe";
                                lblCar2.Text = "Black Toyota Tundra";
                                img2.ImageUrl = "/Images/blacktundra.jpg";
                            }
                            else if (Color == "White")
                            {
                                lblCar1.Text = "White Chevy Camaro";
                                img1.ImageUrl = "/Images/whitecamaro.jpe";
                                lblCar2.Text = "White Toyota Tundra";
                                img2.ImageUrl = "/Images/whitetundra.jpe";
                            }
                        }
                    }
                    else if (Children == "No")
                    {
                        if (Gender == "Male")
                        {
                            if (Color == "Black")
                            {
                                lblCar1.Text = "Black Toyota Highlander";
                                img1.ImageUrl = "/Images/blackhighlander.jpe";
                                lblCar2.Text = "Black Chevy Cruze";
                                img2.ImageUrl = "/Images/blackcruze.jpe";
                            }
                            else if (Color == "White")
                            {
                                lblCar1.Text = "White Toyota Highlander";
                                img1.ImageUrl = "/Images/whitehighlander.jpe";
                                lblCar2.Text = "White Chevy Cruze";
                                img2.ImageUrl = "/Images/whitecruze.jpe";
                            }
                        }
                        else if (Gender == "Female")
                        {
                            if (Color == "Black")
                            {
                                lblCar1.Text = "Black Toyota Camry";
                                img1.ImageUrl = "/Images/blackcamry.jpg";
                                lblCar2.Text = "Black Ford Escape";
                                img2.ImageUrl = "/Images/blackescape.jpg";
                            }
                            else if (Color == "White")
                            {
                                lblCar1.Text = "White Toyota Camry";
                                img1.ImageUrl = "/Images/whitecamry.jpe";
                                lblCar2.Text = "White Ford Escape";
                                img2.ImageUrl = "/Images/whiteescape.jpg";
                            }
                        }
                    }
                }
        }









            //int z = 0;
//            if (carMake == "Toyota")
//            {
//                switch (dobMonth)
//                {
//                    case "01":
//                        lblPet.Text = "Lion";
//                        img1.ImageUrl = "/Images/lion.jpe";
//                        break;
//                    case "02":
//                        lblPet.Text = "Dog";
//                        img1.ImageUrl = "/Images/dog.jpg";
//                        break;
//                    case "03":
//                        lblPet.Text = "Cat";
//                        img1.ImageUrl = "/Images/cat.jpe";
//                        break;
//                    case "04":
//                        lblPet.Text = "Lion";
//                        img1.ImageUrl = "/Images/lion.jpe";
//                        break;
//                    case "05":
//                        lblPet.Text = "Dog";
//                        img1.ImageUrl = "/Images/dog.jpg";
//                        break;
//                    case "06":
//                        lblPet.Text = "Cat";
//                        img1.ImageUrl = "/Images/cat.jpe";
//                        break;
//                    case "07":
//                        lblPet.Text = "Lion";
//                        img1.ImageUrl = "/Images/lion.jpe";
//                        break;
//                    case "08":
//                        lblPet.Text = "Dog";
//                        img1.ImageUrl = "/Images/dog.jpg";
//                        break;
//                    case "09":
//                        lblPet.Text = "Cat";
//                        img1.ImageUrl = "/Images/cat.jpe";
//                        break;
//                    case "10":
//                        lblPet.Text = "Lion";
//                        img1.ImageUrl = "/Images/lion.jpe";
//                        break;
//                    case "11":
//                        lblPet.Text = "Dog";
//                        img1.ImageUrl = "/Images/dog.jpg";
//                        break;
//                    case "12":
//                        lblPet.Text = "Cat";
//                        img1.ImageUrl = "/Images/cat.jpe";
//                        break;

//                }

//            }
//            else if (carMake == "Ford")
//            {
//                switch (dobMonth)
//                {
//                    case "01":
//                        lblPet.Text = "Husky";
//                        img1.ImageUrl = "/Images/husky.jpg";
//                        break;
//                    case "02":
//                        lblPet.Text = "Snake";
//                        img1.ImageUrl = "/Images/snake.jpe";
//                        break;
//                    case "03":
//                        lblPet.Text = "Wolf";
//                        img1.ImageUrl = "/Images/wolf.jpe";
//                        break;
//                    case "04":
//                        lblPet.Text = "Husky";
//                        img1.ImageUrl = "/Images/husky.jpg";
//                        break;
//                    case "05":
//                        lblPet.Text = "Snake";
//                        img1.ImageUrl = "/Images/snake.jpe";
//                        break;
//                    case "06":
//                        lblPet.Text = "Wolf";
//                        img1.ImageUrl = "/Images/wolf.jpe";
//                        break;
//                    case "07":
//                        lblPet.Text = "Husky";
//                        img1.ImageUrl = "/Images/husky.jpg";
//                        break;
//                    case "08":
//                        lblPet.Text = "Snake";
//                        img1.ImageUrl = "/Images/snake.jpe";
//                        break;
//                    case "09":
//                        lblPet.Text = "Wolf";
//                        img1.ImageUrl = "/Images/wolf.jpe";
//                        break;
//                    case "10":
//                        lblPet.Text = "Husky";
//                        img1.ImageUrl = "/Images/husky.jpg";
//                        break;
//                    case "11":
//                        lblPet.Text = "Snake";
//                        img1.ImageUrl = "/Images/snake.jpe";
//                        break;
//                    case "12":
//                        lblPet.Text = "Wolf";
//                        img1.ImageUrl = "/Images/wolf.jpe";
//                        break;
//                }
//            }
//            else if (carMake == "Honda")
//            {
//                switch (dobMonth)
//                {
//                    case "01":
//                        lblPet.Text = "Hamster";
//                        img1.ImageUrl = "/Images/hamster.jpg";
//                        break;
//                    case "02":
//                        lblPet.Text = "Lizard";
//                        img1.ImageUrl = "/Images/lizard.jpe";
//                        break;
//                    case "03":
//                        lblPet.Text = "Pig";
//                        img1.ImageUrl = "/Images/pig.jpg";
//                        break;
//                    case "04":
//                        lblPet.Text = "Hamster";
//                        img1.ImageUrl = "/Images/hamster.jpg";
//                        break;
//                    case "05":
//                        lblPet.Text = "Lizard";
//                        img1.ImageUrl = "/Images/lizard.jpe";
//                        break;
//                    case "06":
//                        lblPet.Text = "Pig";
//                        img1.ImageUrl = "/Images/pig.jpg";
//                        break;
//                    case "07":
//                        lblPet.Text = "Hamster";
//                        img1.ImageUrl = "/Images/hamster.jpg";
//                        break;
//                    case "08":
//                        lblPet.Text = "Lizard";
//                        img1.ImageUrl = "/Images/lizard.jpe";
//                        break;
//                    case "09":
//                        lblPet.Text = "Pig";
//                        img1.ImageUrl = "/Images/pig.jpg";
//                        break;
//                    case "10":
//                        lblPet.Text = "Hamster";
//                        img1.ImageUrl = "/Images/hamster.jpg";
//                        break;
//                    case "11":
//                        lblPet.Text = "Lizard";
//                        img1.ImageUrl = "/Images/lizard.jpe";
//                        break;
//                    case "12":
//                        lblPet.Text = "Pig";
//                        img1.ImageUrl = "/Images/pig.jpg";
//                        break;
//                }
//            }
//            else if (carMake == "Chevy")
//            {
//                switch (dobMonth)
//                {
//                    case "01":
//                        lblPet.Text = "Coyote";
//                        img1.ImageUrl = "/Images/coyote.jpe";
//                        break;
//                    case "02":
//                        lblPet.Text = "Ferret";
//                        img1.ImageUrl = "/Images/ferret.jpe";
//                        break;
//                    case "03":
//                        lblPet.Text = "Ant";
//                        img1.ImageUrl = "/Images/ant.jpe";
//                        break;
//                    case "04":
//                        lblPet.Text = "Coyote";
//                        img1.ImageUrl = "/Images/coyote.jpe";
//                        break;
//                    case "05":
//                        lblPet.Text = "Ferret";
//                        img1.ImageUrl = "/Images/ferret.jpe";
//                        break;
//                    case "06":
//                        lblPet.Text = "Ant";
//                        img1.ImageUrl = "/Images/ant.jpe";
//                        break;
//                    case "07":
//                        lblPet.Text = "Coyote";
//                        img1.ImageUrl = "/Images/coyote.jpe";
//                        break;
//                    case "08":
//                        lblPet.Text = "Ferret";
//                        img1.ImageUrl = "/Images/ferret.jpe";
//                        break;
//                    case "09":
//                        lblPet.Text = "Ant";
//                        img1.ImageUrl = "/Images/ant.jpe";
//                        break;
//                    case "10":
//                        lblPet.Text = "Coyote";
//                        img1.ImageUrl = "/Images/coyote.jpe";
//                        break;
//                    case "11":
//                        lblPet.Text = "Ferret";
//                        img1.ImageUrl = "/Images/ferret.jpe";
//                        break;
//                    case "12":
//                        lblPet.Text = "Ant";
//                        img1.ImageUrl = "/Images/ant.jpe";
//                        break;
//                }
//            }
//            else
//            {
//                switch (dobMonth)
//                {
//                    case "01":
//                        lblPet.Text = "Bear";
//                        img1.ImageUrl = "/Images/bear.jpe";
//                        break;
//                    case "02":
//                        lblPet.Text = "Rabbit";
//                        img1.ImageUrl = "/Images/rabbit.jpe";
//                        break;
//                    case "03":
//                        lblPet.Text = "Bird";
//                        img1.ImageUrl = "/Images/bird.jpe";
//                        break;
//                    case "04":
//                        lblPet.Text = "Bear";
//                        img1.ImageUrl = "/Images/bear.jpe";
//                        break;
//                    case "05":
//                        lblPet.Text = "Rabbit";
//                        img1.ImageUrl = "/Images/rabbit.jpe";
//                        break;
//                    case "06":
//                        lblPet.Text = "Bird";
//                        img1.ImageUrl = "/Images/bird.jpe";
//                        break;
//                    case "07":
//                        lblPet.Text = "Bear";
//                        img1.ImageUrl = "/Images/bear.jpe";
//                        break;
//                    case "08":
//                        lblPet.Text = "Rabbit";
//                        img1.ImageUrl = "/Images/rabbit.jpe";
//                        break;
//                    case "09":
//                        lblPet.Text = "Bird";
//                        img1.ImageUrl = "/Images/bird.jpe";
//                        break;
//                    case "10":
//                        lblPet.Text = "Bear";
//                        img1.ImageUrl = "/Images/bear.jpe";
//                        break;
//                    case "11":
//                        lblPet.Text = "Rabbit";
//                        img1.ImageUrl = "/Images/rabbit.jpe";
//                        break;
//                    case "12":
//                        lblPet.Text = "Bird";
//                        img1.ImageUrl = "/Images/bird.jpe";
//                        break;
//                }
//            }
//         /* do while */
//         int a = 1;   
//         /* do loop execution */
//         do
//         {
//             TextBox1.Text=("Welcome to " + State + "!!!" + z);
//             a++;
//             z++;
//         }
//         while (a < 5);
        }
    }
 

   

   