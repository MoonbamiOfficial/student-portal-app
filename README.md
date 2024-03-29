<h1 align="center">Student Portal</h1>

![MasterHead](https://github.com/MoonbamiOfficial/student-portal-app/assets/141120384/0cb6d72d-3180-46c0-8071-092232562d03)

###

<!-- ABOUT THE PROJECT -->
## About The Project

A simple student portal for students to monitor their academics. This is a project from our subject called _**ITEC 80: Human Computer Interaction**_.
* **Planning Phase:** October 21, 2023 - October 23, 2023
* **Designing Phase:** October 24, 2023 - November 9, 2023
* **Development Phase:** November 9, 2023 - January 31, 2024


###

<a name="getting-started"></a>
<!-- GETTING STARTED -->
## Getting Started

To get started with Student Portal, here are the main things you need;

### Prerequisites

* Visual Studio 2022
* .NET desktop development
* XAMPP

###

### Installation

1. Clone the repository
   ```sh
   git clone https://github.com/MoonbamiOfficial/student-portal-app.git
   ```

###
   
2. Open the folder in Visual Studio 2022

###

3. In the solution explorer (right side), click the _"Switch between solutions and available views"_ button or just find the **StudentPortal.sln** file manually at the src folder and double click it

   ![image](https://github.com/MoonbamiOfficial/student-portal-app/assets/141120384/268dccd6-a98e-489f-ab2c-7c9a2a1d6d29)

###

4. At the top find and click the **tools** > **NuGet Package Manager** > **Manage NuGet Packager for Solution**

   ![image](https://github.com/MoonbamiOfficial/student-portal-app/assets/141120384/a225f528-e68a-4207-b068-2f94249d5393)

###

5. Browse and install the following
   
   * **MySql.Data** by Oracle
   * **NuGet.Frameworks** by Microsoft

###

6. Back at the **tools** click **NuGet Package Manager** > **Package Manager Console**

   * Install **FontAwesome** package
   ```sh
   NuGet\Install-Package FontAwesome.Sharp -Version 6.3.0
   ```

###

7. Open **XAMPP**, start  _Apache_ & _MySql_ then click _MySql_ **admin**

   ![image](https://github.com/MoonbamiOfficial/student-portal-app/assets/141120384/2d8dc7e3-421e-40a0-b201-7b1e1ac05f86)

###

8. In localhost, create a database named
   ```
   stu_portal
   ```

   ![image](https://github.com/MoonbamiOfficial/student-portal-app/assets/141120384/988b898e-616e-42ac-8ee3-ea95026b3886)

###

9. Import **stu_info** from src/StudentPortal/database/stu_info.sql

   ![image](https://github.com/MoonbamiOfficial/student-portal-app/assets/141120384/cf8a98e8-753e-432c-bb08-2119233e4690)

###
   
10. Run **Student Portal**

###

<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

###

<!-- CONTACT -->
## Contact

   ### Developers

   * MoonbamiOfficial - [Discord](https://discord.com/channels/@moonbamioffcl) | [Facebook](https://www.facebook.com/moonbamijam) | [Instagram](https://www.instagram.com/moonbamidesu/) | [Twitter](https://twitter.com/MoonbamiOffcl)

   * Jireh-Sama - [Facebook](https://www.facebook.com/JirehTumbagahan)

   * satanforbid - [Instagram](https://www.instagram.com/prettyboimaks/)

   ### Student Portal

   * Project repository: [student-portal-app](https://github.com/MoonbamiOfficial/student-portal-app.git)

###

<!-- ACKNOWLEDGMENTS -->
## Acknowledgments

* [Backgrounds by Uncle Mugen (mugenjohncel)](https://lemmasoft.renai.us/forums/viewtopic.php?f=52&t=17302#p226871)
* [Student icons created by Freepik - Flaticon](https://www.flaticon.com/free-icons/student)
