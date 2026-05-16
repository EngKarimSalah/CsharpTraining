using System;

namespace ClinimManagementSystem
{
    class Program
    {
        static void Main()
        {
            // ═══════════════════════════════════════════════════════════════════
            // REGION 1: System Storage
            // All data is stored in individual named variables.
            // bool xActive flags track whether a slot is currently occupied.
            // ═══════════════════════════════════════════════════════════════════

            // Capacity constants
            const int MAX_PATIENTS = 3;
            const int MAX_DOCTORS = 2;
            const int MAX_APPOINTMENTS = 3;

            // ── Patient slots ─────────────────────────────────────────────────
            string p1Name = ""; int p1Age = 0; string p1Phone = ""; bool p1Active = false;
            string p2Name = ""; int p2Age = 0; string p2Phone = ""; bool p2Active = false;
            string p3Name = ""; int p3Age = 0; string p3Phone = ""; bool p3Active = false;
            int patientCount = 0;


            // ── Doctor slots ──────────────────────────────────────────────────
            string d1Name = ""; string d1Spec = ""; double d1Fee = 0; bool d1Active = false;
            string d2Name = ""; string d2Spec = ""; double d2Fee = 0; bool d2Active = false;
            int doctorCount = 0;

            // ── Appointment slots ─────────────────────────────────────────────
            string a1Patient = ""; string a1Doctor = ""; string a1Date = ""; string a1Status = ""; bool a1Active = false;
            string a2Patient = ""; string a2Doctor = ""; string a2Date = ""; string a2Status = ""; bool a2Active = false;
            string a3Patient = ""; string a3Doctor = ""; string a3Date = ""; string a3Status = ""; bool a3Active = false;
            int appointmentCount = 0;

            // ═══════════════════════════════════════════════════════════════════
            // REGION 2: Main Menu
            // Outer while loop keeps the program running until the user exits.
            // switch-case routes to the correct sub-menu.
            // ═══════════════════════════════════════════════════════════════════

            while (true)
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════════╗");
                Console.WriteLine("║     CLINIC MANAGEMENT SYSTEM         ║");
                Console.WriteLine("╠══════════════════════════════════════╣");
                Console.WriteLine("║  1. Patient Management               ║");
                Console.WriteLine("║  2. Doctor Management                ║");
                Console.WriteLine("║  3. Appointment Management           ║");
                Console.WriteLine("║  0. Exit                             ║");
                Console.WriteLine("╚══════════════════════════════════════╝");
                Console.Write("Enter your choice: ");

                int mainChoice = Convert.ToInt32(Console.ReadLine());

                switch (mainChoice)
                {
                    // ══════════════════════════════════════════════════════════
                    // REGION 3 + 4: Patient Sub-Menu & Operations
                    // ══════════════════════════════════════════════════════════
                    case 1:
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("╔══════════════════════════════════════╗");
                            Console.WriteLine("║     PATIENT MANAGEMENT               ║");
                            Console.WriteLine("╠══════════════════════════════════════╣");
                            Console.WriteLine("║  1. Add New Patient                  ║");
                            Console.WriteLine("║  2. Display All Patients             ║");
                            Console.WriteLine("║  3. Update Patient Phone             ║");
                            Console.WriteLine("║  4. Delete Patient                   ║");
                            Console.WriteLine("║  0. Back to Main Menu                ║");
                            Console.WriteLine("╚══════════════════════════════════════╝");
                            Console.Write("Enter your choice: ");

                            int patientChoice = Convert.ToInt32(Console.ReadLine());

                            switch (patientChoice)
                            {
                                // ── ADD Patient ───────────────────────────────
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("── Add New Patient ──────────────────────");

                                    // Check capacity
                                    if (patientCount == MAX_PATIENTS)
                                    {
                                        Console.WriteLine("Clinic is full. Cannot add more patients.");
                                        Console.ReadKey();
                                        break;
                                    }

                                    // Read and validate name
                                    Console.Write("Enter patient name: ");
                                    string newPName = Console.ReadLine();
                                    if (newPName == "")
                                    {
                                        Console.WriteLine("Name cannot be empty.");
                                        Console.ReadKey();
                                        break;
                                    }

                                    // Read and validate age
                                    Console.Write("Enter patient age: ");
                                    int newPAge = Convert.ToInt32(Console.ReadLine());
                                    if (newPAge < 1 || newPAge > 120)
                                    {
                                        Console.WriteLine("Age must be between 1 and 120.");
                                        Console.ReadKey();
                                        break;
                                    }

                                    // Read phone
                                    Console.Write("Enter patient phone: ");
                                    string newPPhone = Console.ReadLine();

                                    // Store in first available slot
                                    if (!p1Active)
                                    {
                                        p1Name = newPName; p1Age = newPAge; p1Phone = newPPhone; p1Active = true;
                                    }
                                    else if (!p2Active)
                                    {
                                        p2Name = newPName; p2Age = newPAge; p2Phone = newPPhone; p2Active = true;
                                    }
                                    else if (!p3Active)
                                    {
                                        p3Name = newPName; p3Age = newPAge; p3Phone = newPPhone; p3Active = true;
                                    }

                                    patientCount++;
                                    Console.WriteLine("Patient added successfully.");
                                    Console.ReadKey();
                                    break;

                                // ── DISPLAY ALL Patients ──────────────────────
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("── All Patients ─────────────────────────");

                                    if (patientCount == 0)
                                    {
                                        Console.WriteLine("No patients registered.");
                                        Console.ReadKey();
                                        break;
                                    }

                                    // Manual display counter — no arrays, no loops over slots
                                    int pDisplayNum = 1;

                                    if (p1Active)
                                    {
                                        Console.WriteLine("Patient #" + pDisplayNum);
                                        Console.WriteLine("  Name  : " + p1Name);
                                        Console.WriteLine("  Age   : " + p1Age);
                                        Console.WriteLine("  Phone : " + p1Phone);
                                        Console.WriteLine("─────────────────────────────────────────");
                                        pDisplayNum++;
                                    }
                                    if (p2Active)
                                    {
                                        Console.WriteLine("Patient #" + pDisplayNum);
                                        Console.WriteLine("  Name  : " + p2Name);
                                        Console.WriteLine("  Age   : " + p2Age);
                                        Console.WriteLine("  Phone : " + p2Phone);
                                        Console.WriteLine("─────────────────────────────────────────");
                                        pDisplayNum++;
                                    }
                                    if (p3Active)
                                    {
                                        Console.WriteLine("Patient #" + pDisplayNum);
                                        Console.WriteLine("  Name  : " + p3Name);
                                        Console.WriteLine("  Age   : " + p3Age);
                                        Console.WriteLine("  Phone : " + p3Phone);
                                        Console.WriteLine("─────────────────────────────────────────");
                                    }

                                    Console.ReadKey();
                                    break;

                                // ── UPDATE Patient Phone ──────────────────────
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("── Update Patient Phone ─────────────────");
                                    Console.Write("Enter patient name to update: ");
                                    string updatePName = Console.ReadLine();

                                    if (p1Active && p1Name == updatePName)
                                    {
                                        Console.Write("Enter new phone number: ");
                                        p1Phone = Console.ReadLine();
                                        Console.WriteLine("Phone updated successfully.");
                                    }
                                    else if (p2Active && p2Name == updatePName)
                                    {
                                        Console.Write("Enter new phone number: ");
                                        p2Phone = Console.ReadLine();
                                        Console.WriteLine("Phone updated successfully.");
                                    }
                                    else if (p3Active && p3Name == updatePName)
                                    {
                                        Console.Write("Enter new phone number: ");
                                        p3Phone = Console.ReadLine();
                                        Console.WriteLine("Phone updated successfully.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Patient not found.");
                                    }

                                    Console.ReadKey();
                                    break;

                                // ── DELETE Patient ────────────────────────────
                                case 4:
                                    Console.Clear();
                                    Console.WriteLine("── Delete Patient ───────────────────────");
                                    Console.Write("Enter patient name to delete: ");
                                    string deletePName = Console.ReadLine();

                                    if (p1Active && p1Name == deletePName)
                                    {
                                        p1Name = ""; p1Age = 0; p1Phone = ""; p1Active = false;
                                        patientCount--;
                                        Console.WriteLine("Patient deleted.");
                                    }
                                    else if (p2Active && p2Name == deletePName)
                                    {
                                        p2Name = ""; p2Age = 0; p2Phone = ""; p2Active = false;
                                        patientCount--;
                                        Console.WriteLine("Patient deleted.");
                                    }
                                    else if (p3Active && p3Name == deletePName)
                                    {
                                        p3Name = ""; p3Age = 0; p3Phone = ""; p3Active = false;
                                        patientCount--;
                                        Console.WriteLine("Patient deleted.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Patient not found.");
                                    }

                                    Console.ReadKey();
                                    break;

                                case 0:
                                    break;

                                default:
                                    Console.WriteLine("Invalid choice. Please try again.");
                                    Console.ReadKey();
                                    break;
                            }

                            // Break out of patient sub-menu while loop
                            if (patientChoice == 0)
                                break;
                        }
                        break;

                    // ══════════════════════════════════════════════════════════
                    // REGION 3 + 4: Doctor Sub-Menu & Operations
                    // ══════════════════════════════════════════════════════════
                    case 2:
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("╔══════════════════════════════════════╗");
                            Console.WriteLine("║     DOCTOR MANAGEMENT                ║");
                            Console.WriteLine("╠══════════════════════════════════════╣");
                            Console.WriteLine("║  1. Add New Doctor                   ║");
                            Console.WriteLine("║  2. Display All Doctors              ║");
                            Console.WriteLine("║  3. Update Consultation Fee          ║");
                            Console.WriteLine("║  4. Delete Doctor                    ║");
                            Console.WriteLine("║  0. Back to Main Menu                ║");
                            Console.WriteLine("╚══════════════════════════════════════╝");
                            Console.Write("Enter your choice: ");

                            int doctorChoice = Convert.ToInt32(Console.ReadLine());

                            switch (doctorChoice)
                            {
                                // ── ADD Doctor ────────────────────────────────
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("── Add New Doctor ───────────────────────");

                                    if (doctorCount == MAX_DOCTORS)
                                    {
                                        Console.WriteLine("No available doctor slots.");
                                        Console.ReadKey();
                                        break;
                                    }

                                    Console.Write("Enter doctor name: ");
                                    string newDName = Console.ReadLine();
                                    if (newDName == "")
                                    {
                                        Console.WriteLine("Name cannot be empty.");
                                        Console.ReadKey();
                                        break;
                                    }

                                    Console.Write("Enter specialization: ");
                                    string newDSpec = Console.ReadLine();
                                    if (newDSpec == "")
                                    {
                                        Console.WriteLine("Specialization cannot be empty.");
                                        Console.ReadKey();
                                        break;
                                    }

                                    Console.Write("Enter consultation fee: ");
                                    double newDFee = Convert.ToDouble(Console.ReadLine());
                                    if (newDFee < 0)
                                    {
                                        Console.WriteLine("Fee cannot be negative.");
                                        Console.ReadKey();
                                        break;
                                    }

                                    if (!d1Active)
                                    {
                                        d1Name = newDName; d1Spec = newDSpec; d1Fee = newDFee; d1Active = true;
                                    }
                                    else if (!d2Active)
                                    {
                                        d2Name = newDName; d2Spec = newDSpec; d2Fee = newDFee; d2Active = true;
                                    }

                                    doctorCount++;
                                    Console.WriteLine("Doctor added successfully.");
                                    Console.ReadKey();
                                    break;

                                // ── DISPLAY ALL Doctors ───────────────────────
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("── All Doctors ──────────────────────────");

                                    if (doctorCount == 0)
                                    {
                                        Console.WriteLine("No doctors registered.");
                                        Console.ReadKey();
                                        break;
                                    }

                                    int dDisplayNum = 1;

                                    if (d1Active)
                                    {
                                        Console.WriteLine("Doctor #" + dDisplayNum);
                                        Console.WriteLine("  Name           : " + d1Name);
                                        Console.WriteLine("  Specialization : " + d1Spec);
                                        Console.WriteLine("  Fee            : " + d1Fee);
                                        Console.WriteLine("─────────────────────────────────────────");
                                        dDisplayNum++;
                                    }
                                    if (d2Active)
                                    {
                                        Console.WriteLine("Doctor #" + dDisplayNum);
                                        Console.WriteLine("  Name           : " + d2Name);
                                        Console.WriteLine("  Specialization : " + d2Spec);
                                        Console.WriteLine("  Fee            : " + d2Fee);
                                        Console.WriteLine("─────────────────────────────────────────");
                                    }

                                    Console.ReadKey();
                                    break;

                                // ── UPDATE Consultation Fee ───────────────────
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("── Update Consultation Fee ──────────────");
                                    Console.Write("Enter doctor name: ");
                                    string updateDName = Console.ReadLine();

                                    if (d1Active && d1Name == updateDName)
                                    {
                                        Console.Write("Enter new fee: ");
                                        double newFee1 = Convert.ToDouble(Console.ReadLine());
                                        if (newFee1 < 0)
                                        {
                                            Console.WriteLine("Fee cannot be negative.");
                                        }
                                        else
                                        {
                                            d1Fee = newFee1;
                                            Console.WriteLine("Fee updated successfully.");
                                        }
                                    }
                                    else if (d2Active && d2Name == updateDName)
                                    {
                                        Console.Write("Enter new fee: ");
                                        double newFee2 = Convert.ToDouble(Console.ReadLine());
                                        if (newFee2 < 0)
                                        {
                                            Console.WriteLine("Fee cannot be negative.");
                                        }
                                        else
                                        {
                                            d2Fee = newFee2;
                                            Console.WriteLine("Fee updated successfully.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Doctor not found.");
                                    }

                                    Console.ReadKey();
                                    break;

                                // ── DELETE Doctor ─────────────────────────────
                                case 4:
                                    Console.Clear();
                                    Console.WriteLine("── Delete Doctor ────────────────────────");
                                    Console.Write("Enter doctor name to delete: ");
                                    string deleteDName = Console.ReadLine();

                                    if (d1Active && d1Name == deleteDName)
                                    {
                                        d1Name = ""; d1Spec = ""; d1Fee = 0; d1Active = false;
                                        doctorCount--;
                                        Console.WriteLine("Doctor removed.");
                                    }
                                    else if (d2Active && d2Name == deleteDName)
                                    {
                                        d2Name = ""; d2Spec = ""; d2Fee = 0; d2Active = false;
                                        doctorCount--;
                                        Console.WriteLine("Doctor removed.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Doctor not found.");
                                    }

                                    Console.ReadKey();
                                    break;

                                case 0:
                                    break;

                                default:
                                    Console.WriteLine("Invalid choice. Please try again.");
                                    Console.ReadKey();
                                    break;
                            }

                            if (doctorChoice == 0)
                                break;
                        }
                        break;

                    // ══════════════════════════════════════════════════════════
                    // REGION 3 + 4: Appointment Sub-Menu & Operations
                    // ══════════════════════════════════════════════════════════
                    case 3:
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("╔══════════════════════════════════════╗");
                            Console.WriteLine("║     APPOINTMENT MANAGEMENT           ║");
                            Console.WriteLine("╠══════════════════════════════════════╣");
                            Console.WriteLine("║  1. Book New Appointment             ║");
                            Console.WriteLine("║  2. Display All Appointments         ║");
                            Console.WriteLine("║  3. Update Appointment Status        ║");
                            Console.WriteLine("║  4. Cancel Appointment               ║");
                            Console.WriteLine("║  0. Back to Main Menu                ║");
                            Console.WriteLine("╚══════════════════════════════════════╝");
                            Console.Write("Enter your choice: ");

                            int appointmentChoice = Convert.ToInt32(Console.ReadLine());

                            switch (appointmentChoice)
                            {
                                // ── BOOK Appointment ──────────────────────────
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("── Book New Appointment ─────────────────");

                                    // Guard: capacity and prerequisites
                                    if (appointmentCount == MAX_APPOINTMENTS)
                                    {
                                        Console.WriteLine("No available appointment slots.");
                                        Console.ReadKey();
                                        break;
                                    }
                                    if (patientCount == 0 || doctorCount == 0)
                                    {
                                        Console.WriteLine("Please add patients and doctors first.");
                                        Console.ReadKey();
                                        break;
                                    }

                                    // Display active patients
                                    Console.WriteLine("── Select Patient ───────────────────────");
                                    int pNum = 1;
                                    if (p1Active) { Console.WriteLine(pNum + ". " + p1Name); pNum++; }
                                    if (p2Active) { Console.WriteLine(pNum + ". " + p2Name); pNum++; }
                                    if (p3Active) { Console.WriteLine(pNum + ". " + p3Name); }

                                    Console.Write("Enter patient number: ");
                                    int pChoice = Convert.ToInt32(Console.ReadLine());

                                    // Map choice to patient name
                                    string chosenPatient = "";
                                    int pCounter = 1;

                                    if (p1Active)
                                    {
                                        if (pChoice == pCounter) chosenPatient = p1Name;
                                        pCounter++;
                                    }
                                    if (p2Active)
                                    {
                                        if (pChoice == pCounter) chosenPatient = p2Name;
                                        pCounter++;
                                    }
                                    if (p3Active)
                                    {
                                        if (pChoice == pCounter) chosenPatient = p3Name;
                                    }

                                    if (chosenPatient == "")
                                    {
                                        Console.WriteLine("Invalid patient selection.");
                                        Console.ReadKey();
                                        break;
                                    }

                                    // Display active doctors
                                    Console.WriteLine("── Select Doctor ────────────────────────");
                                    int dNum = 1;
                                    if (d1Active) { Console.WriteLine(dNum + ". " + d1Name + "  (" + d1Spec + ")  Fee: " + d1Fee); dNum++; }
                                    if (d2Active) { Console.WriteLine(dNum + ". " + d2Name + "  (" + d2Spec + ")  Fee: " + d2Fee); }

                                    Console.Write("Enter doctor number: ");
                                    int dChoice = Convert.ToInt32(Console.ReadLine());

                                    // Map choice to doctor name
                                    string chosenDoctor = "";
                                    int dCounter = 1;

                                    if (d1Active)
                                    {
                                        if (dChoice == dCounter) chosenDoctor = d1Name;
                                        dCounter++;
                                    }
                                    if (d2Active)
                                    {
                                        if (dChoice == dCounter) chosenDoctor = d2Name;
                                    }

                                    if (chosenDoctor == "")
                                    {
                                        Console.WriteLine("Invalid doctor selection.");
                                        Console.ReadKey();
                                        break;
                                    }

                                    // Read appointment date
                                    Console.Write("Enter appointment date (DD/MM/YYYY): ");
                                    string newADate = Console.ReadLine();

                                    // Duplicate check — compare against every active slot
                                    bool isDuplicate = false;

                                    if (a1Active && a1Patient == chosenPatient && a1Doctor == chosenDoctor && a1Date == newADate)
                                        isDuplicate = true;
                                    else if (a2Active && a2Patient == chosenPatient && a2Doctor == chosenDoctor && a2Date == newADate)
                                        isDuplicate = true;
                                    else if (a3Active && a3Patient == chosenPatient && a3Doctor == chosenDoctor && a3Date == newADate)
                                        isDuplicate = true;

                                    if (isDuplicate)
                                    {
                                        Console.WriteLine("Duplicate appointment. This booking already exists.");
                                        Console.ReadKey();
                                        break;
                                    }

                                    // Store in first free slot
                                    if (!a1Active)
                                    {
                                        a1Patient = chosenPatient; a1Doctor = chosenDoctor;
                                        a1Date = newADate; a1Status = "Scheduled"; a1Active = true;
                                    }
                                    else if (!a2Active)
                                    {
                                        a2Patient = chosenPatient; a2Doctor = chosenDoctor;
                                        a2Date = newADate; a2Status = "Scheduled"; a2Active = true;
                                    }
                                    else if (!a3Active)
                                    {
                                        a3Patient = chosenPatient; a3Doctor = chosenDoctor;
                                        a3Date = newADate; a3Status = "Scheduled"; a3Active = true;
                                    }

                                    appointmentCount++;
                                    Console.WriteLine("Appointment booked successfully.");
                                    Console.ReadKey();
                                    break;

                                // ── DISPLAY ALL Appointments ──────────────────
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("── All Appointments ─────────────────────");

                                    if (appointmentCount == 0)
                                    {
                                        Console.WriteLine("No appointments booked.");
                                        Console.ReadKey();
                                        break;
                                    }

                                    int aDisplayNum = 1;

                                    if (a1Active)
                                    {
                                        Console.WriteLine("Appointment #" + aDisplayNum);
                                        Console.WriteLine("  Patient : " + a1Patient);
                                        Console.WriteLine("  Doctor  : " + a1Doctor);
                                        Console.WriteLine("  Date    : " + a1Date);
                                        Console.WriteLine("  Status  : " + a1Status);
                                        Console.WriteLine("─────────────────────────────────────────");
                                        aDisplayNum++;
                                    }
                                    if (a2Active)
                                    {
                                        Console.WriteLine("Appointment #" + aDisplayNum);
                                        Console.WriteLine("  Patient : " + a2Patient);
                                        Console.WriteLine("  Doctor  : " + a2Doctor);
                                        Console.WriteLine("  Date    : " + a2Date);
                                        Console.WriteLine("  Status  : " + a2Status);
                                        Console.WriteLine("─────────────────────────────────────────");
                                        aDisplayNum++;
                                    }
                                    if (a3Active)
                                    {
                                        Console.WriteLine("Appointment #" + aDisplayNum);
                                        Console.WriteLine("  Patient : " + a3Patient);
                                        Console.WriteLine("  Doctor  : " + a3Doctor);
                                        Console.WriteLine("  Date    : " + a3Date);
                                        Console.WriteLine("  Status  : " + a3Status);
                                        Console.WriteLine("─────────────────────────────────────────");
                                    }

                                    Console.ReadKey();
                                    break;

                                // ── UPDATE Appointment Status ─────────────────
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("── Update Appointment Status ────────────");

                                    if (appointmentCount == 0)
                                    {
                                        Console.WriteLine("No appointments to update.");
                                        Console.ReadKey();
                                        break;
                                    }

                                    // Display active appointments with slot numbers
                                    int aUpdateNum = 1;
                                    if (a1Active) { Console.WriteLine(aUpdateNum + ". " + a1Patient + " | " + a1Doctor + " | " + a1Date + " | " + a1Status); aUpdateNum++; }
                                    if (a2Active) { Console.WriteLine(aUpdateNum + ". " + a2Patient + " | " + a2Doctor + " | " + a2Date + " | " + a2Status); aUpdateNum++; }
                                    if (a3Active) { Console.WriteLine(aUpdateNum + ". " + a3Patient + " | " + a3Doctor + " | " + a3Date + " | " + a3Status); }

                                    Console.Write("Enter appointment number: ");
                                    int aSlotChoice = Convert.ToInt32(Console.ReadLine());

                                    // Map the display number back to a slot
                                    // We need to know which slot corresponds to display number aSlotChoice
                                    string targetAPatient = "";
                                    string targetADoctor = "";
                                    string targetADate = "";
                                    int mappedSlot = 0;   // 1, 2, or 3

                                    int aMapCounter = 1;
                                    if (a1Active)
                                    {
                                        if (aSlotChoice == aMapCounter) { targetAPatient = a1Patient; targetADoctor = a1Doctor; targetADate = a1Date; mappedSlot = 1; }
                                        aMapCounter++;
                                    }
                                    if (a2Active)
                                    {
                                        if (aSlotChoice == aMapCounter) { targetAPatient = a2Patient; targetADoctor = a2Doctor; targetADate = a2Date; mappedSlot = 2; }
                                        aMapCounter++;
                                    }
                                    if (a3Active)
                                    {
                                        if (aSlotChoice == aMapCounter) { targetAPatient = a3Patient; targetADoctor = a3Doctor; targetADate = a3Date; mappedSlot = 3; }
                                    }

                                    if (mappedSlot == 0)
                                    {
                                        Console.WriteLine("Invalid selection.");
                                        Console.ReadKey();
                                        break;
                                    }

                                    // Choose new status
                                    Console.WriteLine("Select new status:");
                                    Console.WriteLine("  1. Scheduled");
                                    Console.WriteLine("  2. Completed");
                                    Console.WriteLine("  3. Cancelled");
                                    Console.Write("Enter choice: ");
                                    int statusChoice = Convert.ToInt32(Console.ReadLine());

                                    string newStatus = "";
                                    switch (statusChoice)
                                    {
                                        case 1: newStatus = "Scheduled"; break;
                                        case 2: newStatus = "Completed"; break;
                                        case 3: newStatus = "Cancelled"; break;
                                        default:
                                            Console.WriteLine("Invalid status choice.");
                                            Console.ReadKey();
                                            break;
                                    }

                                    // Apply to the correct slot
                                    if (newStatus != "")
                                    {
                                        if (mappedSlot == 1) a1Status = newStatus;
                                        else if (mappedSlot == 2) a2Status = newStatus;
                                        else if (mappedSlot == 3) a3Status = newStatus;

                                        Console.WriteLine("Status updated to: " + newStatus);
                                    }

                                    Console.ReadKey();
                                    break;

                                // ── CANCEL Appointment ────────────────────────
                                case 4:
                                    Console.Clear();
                                    Console.WriteLine("── Cancel Appointment ───────────────────");
                                    Console.Write("Enter patient name: ");
                                    string cancelPName = Console.ReadLine();
                                    Console.Write("Enter appointment date (DD/MM/YYYY): ");
                                    string cancelDate = Console.ReadLine();

                                    // Find matching active slot and set status to Cancelled
                                    // (record is kept — only status changes)
                                    if (a1Active && a1Patient == cancelPName && a1Date == cancelDate)
                                    {
                                        a1Status = "Cancelled";
                                        Console.WriteLine("Appointment cancelled.");
                                    }
                                    else if (a2Active && a2Patient == cancelPName && a2Date == cancelDate)
                                    {
                                        a2Status = "Cancelled";
                                        Console.WriteLine("Appointment cancelled.");
                                    }
                                    else if (a3Active && a3Patient == cancelPName && a3Date == cancelDate)
                                    {
                                        a3Status = "Cancelled";
                                        Console.WriteLine("Appointment cancelled.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Appointment not found.");
                                    }

                                    Console.ReadKey();
                                    break;

                                case 0:
                                    break;

                                default:
                                    Console.WriteLine("Invalid choice. Please try again.");
                                    Console.ReadKey();
                                    break;
                            }

                            if (appointmentChoice == 0)
                                break;
                        }
                        break;

                    // ── Exit ──────────────────────────────────────────────────
                    case 0:
                        Console.Clear();
                        Console.WriteLine("─────────────────────────────────────────");
                        Console.WriteLine("  CLINIC SUMMARY");
                        Console.WriteLine("─────────────────────────────────────────");
                        Console.WriteLine("  Total Patients     : " + patientCount);
                        Console.WriteLine("  Total Doctors      : " + doctorCount);
                        Console.WriteLine("  Total Appointments : " + appointmentCount);
                        Console.WriteLine("─────────────────────────────────────────");
                        Console.WriteLine("Thank you for using the Clinic Management System. Goodbye!");
                        Console.ReadKey();
                        return;   // Exit Main()

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
