# StudentSorter

This is an app for randomly creating groups of students. The original idea for the app was an assignment in Algebra II where the students chose their own groups and it went poorly.
I created the first iteration of the app in Java, and used it successfully. The second iteration of the app worked much better and added support for any number of students and groups
as well as the ability to upload a file containing student names and group information. The third iteration of the app was written in C# and was the first desktop app version that did
not add much and only served to clutter things further. I scrapped iteration 3 and created a web page iteration, iteration 4. Iteration 4 was a watered-down web page that will never see
the light of day. I am now on iteration 5, most likely my final, ultimate iteration of the app. I tried to minimize clutter in the user interface and make buttons and instructions
concise.

# Features

The app currently will allow you to create students through a simple interface or upload an existing JSON file containing the names of students. The same applies for groups.
You are able to click on a student or group to view extra information.

Students have a name and, if applicable, an assigned determinant.
The determinant is the value that the sorter will use to put students into groups.
Groups have a name, capacity, minimum accepted determinant, and a maximum accepted determinant.

# How the Sorting Works

The sorter will first iterate over all the groups, and, for each group, it will iterate through every student and check if they are eligible to join the group.
If the student is eligible, they will be added to the group. After the sorter iterates through all the groups and added students based on determinant, it will perform a second
iteration and add students based on what groups have space left.

# Upcoming Features

<ul>
  <li> None </li>
</ul>
