# Lottery Application for Employees

The **Lottery Application** is a user-friendly desktop application designed to facilitate fair and transparent employee lotteries within organizations. The app streamlines the process of selecting random employees for various purposes, such as awards, recognition, or other events.

## How It Works

1. **Employee Data Management:**
   - Import a list of employees from an Excel file located in the `bin/Debug/FileData` directory. The Excel file should contain essential information such as employee numbers, names, departments, and a status column indicating whether an employee has been selected.
   - The app dynamically loads and updates employee data from the specified file, ensuring the latest information is always available.

2. **Random Selection:**
   - The heart of the application is the ability to randomly select employees for various purposes.
   - The selection process is unbiased, transparent, and ensures each eligible employee in the Excel file with the status is not "Selected" has an equal chance of being chosen.

3. **Automatic Status Updates:**
   - The app automatically updates the status of selected employees in the Excel file, preventing duplicate selections and maintaining an accurate record of past lotteries.

4. **User-Friendly Interface:**
   - A simple and intuitive user interface allows users to easily load employee data from the `bin/Debug/FileData` directory, initiate lotteries, and view the selected employee's details.

5. **Customization Options:**
   - Users can customize the lottery process based on their specific needs, including the ability to exclude certain employees, departments, or set specific criteria for eligibility.

## Getting Started

To use the Lottery Application:
1. Download and install the application.
2. Place your Excel file inside the `bin/Debug/FileData` directory. The file should include the employee status column.
3. Load the Excel file from the `bin/Debug/FileData` directory into the application.
4. Initiate the lottery process.

Start making your employee lotteries more efficient and transparent with the Lottery Application!
