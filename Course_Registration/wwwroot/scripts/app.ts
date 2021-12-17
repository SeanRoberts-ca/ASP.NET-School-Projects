function InstructorSubmit(event: { preventDefault: () => void; }) {
    event.preventDefault();
    let mystring = "";
    let FirstName = (document.getElementById("FirstName") as HTMLInputElement).value;
    let LastName = (document.getElementById("LastName") as HTMLInputElement).value;
    let Email = (document.getElementById("Email") as HTMLInputElement).value;
    let isValid = true;
    var errors: string[];
    errors = [];
    if (FirstName == '') {
        isValid = false;
        errors[0] = 'First Name Cannot be empty';
    } else if (FirstName.length > 25) {
        isValid = false;
        errors[4] = 'First Name Cannot be more than 25 characters long';
    };
    if (LastName == '') {
        isValid = false;
        errors[1] = 'Last Name Cannot be empty';
    } else if (LastName.length > 25) {
        isValid = false;
        errors[5] = 'Last Name Cannot be more than 25 characters long';
    };
    if (Email == '') {
        isValid = false;
        errors[2] = 'Email Cannot be empty';

    } else {
        let regexp = new RegExp(/^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/);
        if (!regexp.test(Email)) {
            isValid = false;
            errors[3] = 'Email Address is not valid';
    } else if (Email.length > 100) {
            isValid = false;
            errors[6] = 'Email Cannot be more than 100 characters long';
        };
    };

    if (isValid == false) {

        for (let item of errors) {
            if (item != undefined) {
                mystring = mystring + "- " + item + "\n";
            }
            //console.log(item);
        }
        document.getElementById('message').innerText = mystring;
        return false;

        
    } else {

        var myForm = <HTMLFormElement>document.getElementById('Iform');
        myForm.submit()

    };
        
}//End InstructorSubmit


function StudentSubmit(event: { preventDefault: () => void; }) {
    event.preventDefault();
    let mystring = "";
    let FirstName = (document.getElementById("FirstName") as HTMLInputElement).value;
    let LastName = (document.getElementById("LastName") as HTMLInputElement).value;
    let Email = (document.getElementById("Email") as HTMLInputElement).value;
    let PhoneNumber = (document.getElementById("PhoneNumber") as HTMLInputElement).value;
    let CourseId = (document.getElementById("CourseId") as HTMLInputElement).value;
    let isValid = true;
    var errors: string[];
    errors = [];
    if (FirstName == '') {
        isValid = false;
        errors[0] = 'First Name Cannot be empty';
    } else if (FirstName.length > 25) {
        isValid = false;
        errors[4] = 'First Name Cannot be more than 25 characters long';
    };
    if (LastName == '') {
        isValid = false;
        errors[1] = 'Last Name Cannot be empty';
    } else if (LastName.length > 25) {
        isValid = false;
        errors[5] = 'Last Name Cannot be more than 25 characters long';
    };
    if (Email == '') {
        isValid = false;
        errors[2] = 'Email Cannot be empty';

    } else {
        let regexp = new RegExp(/^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/);
        if (!regexp.test(Email)) {
            isValid = false;
            errors[3] = 'Email Address is not valid';
        } else if (Email.length > 100) {
            isValid = false;
            errors[6] = 'Email Cannot be more than 100 characters long';
        };
    };
    if (PhoneNumber == '') {
        isValid = false;
        errors[7] = 'Phone Number Cannot be empty';

    } else {
        let regexp = new RegExp(/^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$/im);
        if (!regexp.test(PhoneNumber)) {
            isValid = false;
            errors[8] = 'Phone Number is not valid. Use Numeric digits only.';
        } else if (PhoneNumber.length > 25) {
            isValid = false;
            errors[9] = 'Phone Number Cannot be more than 25 characters long';
        };
    };
    if (CourseId == '' || CourseId == undefined) {
        isValid = false;
        errors[10] = 'Please select at least One Course.';

    }

    if (isValid == false) {

        for (let item of errors) {
            if (item != undefined) {
                mystring = mystring + "- " + item + "\n";
            }
            console.log(item);
        }
        document.getElementById('message').innerText = mystring;
        return false;


    } else {

        var myForm = <HTMLFormElement>document.getElementById('Sform');
        myForm.submit()

    };

}//End StudentSubmit

function CourseSubmit(event: { preventDefault: () => void; }) {
    event.preventDefault();
    let mystring = "";
    let CourseName = (document.getElementById("CourseName") as HTMLInputElement).value;
    let Description = (document.getElementById("Description") as HTMLInputElement).value;
    let isValid = true;
    var errors: string[];
    errors = [];
    if (CourseName == '') {
        isValid = false;
        errors[0] = 'Course Name Cannot be empty';
    } else if (CourseName.length > 50) {
        isValid = false;
        errors[1] = 'Course Name Cannot be more than 50 characters long';
    };
    if (Description == '') {
        isValid = false;
        errors[2] = 'Description Cannot be empty';
    } else if (Description.length > 150) {
        isValid = false;
        errors[3] = 'Description Cannot be more than 150 characters long';
    };

    if (isValid == false) {

        for (let item of errors) {
            if (item != undefined) {
                mystring = mystring + "- " + item + "\n";
            }
            console.log(item);
        }
        document.getElementById('message').innerText = mystring;
        return false;


    } else {

        var myForm = <HTMLFormElement>document.getElementById('Cform');
        myForm.submit()

    };

}//End CourseSubmit