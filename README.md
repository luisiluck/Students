## Exercise 1 - Test Pan correction
<table class="source-tableeditor">
<tbody>
<tr>
<td>Name</td>
<td colspan="2">TC-002 Create a Student</td>
</tr>
<tr>
<td>Pre-condition</td>
<td colspan="2">- Be logged in as Administrator</br>
- Main Menu is accessible</td>
</tr>
<tr>
<td>Step</td>
<td>Action</td>
<td>Expected result</td>
</tr>
<tr>
<td>1</td>
<td>Access to the section "Students&rdquo; menu option</td>
<td>- Appears a list of Students in a table<br />- Appears "Add new Student" link in top-right corner of the page</td>
</tr>
<tr>
<td>2</td>
<td>Click "Add a new Student" link</td>
<td>The form to create a new Student is displayed with the next elements (*: mandatory)<br />- DNI* field<br />- Name* field<br />- Surname* field<br />- Date of Birth* field<br />- Phone* field<br />- "Save" button</td>
</tr>
<tr>
<td>3</td>
<td>Fill mandatory fields</td>
<td>It is able to save new user</td>
</tr>
<tr>
<td>4</td>
<td>Click "Save" button</td>
<td>- The Student is created<br />- message appears confirming the operation</td>
</tr>
</tbody>
</table>

## Excersise 2 - Bug Creation 

>![](/userDatailsMockUp.png)

<table class="source-tableeditor">
<tbody>
<tr>
<td>Name</td>
<td colspan="2">Bug - User Details view issues</td>
</tr>
<tr>
<td>Pre-condition</td>
<td colspan="2">Be logged in as Administrator</td>
</tr>
<tr>
<td>Step</td>
<td>Action</td>
<td>Expected result</td>
</tr>
<tr>
<td>1</td>
<td>Access to the section "Students&rdquo; menu option</td>
<td>- Appears a list of Students in a table<br />- Appears "Add new Student" link in top-right corner of the page</td>
</tr>
<tr>
<td>2</td>
<td>Click "Add a new Student" link</td>
<td>The form to create a new Student is displayed with the next elements (*: mandatory)<br />- DNI* field<br />- Name* field<br />- Surname* field<br />- Date of Birth* field<br />- Phone* field<br />- "Save" button</td>
</tr>
<tr>
<td colspan="2">Actual Result</td>
<td><span>-</span><span> 'Save' button is not displayed<br /></span><span>-</span><span> Wrong Placeholders in fields (Email Address)<br /></span><span>-</span><span> 'DNI', 'Surname', 'Phone' and 'Date of Birth' labels are not tagged as mandatory (*)</span></td>
</tr>
<tr>
<td colspan="2">Expected Result</td>
<td>- 'Save' button should be displayed at foot of form<br />- Each field should contain relevant placeholder<br />- All field labels should be tagged as mandatory</td>
</tr>
</tbody>
</table>

## Exercise 3 - Test Plan Creation

<table class="source-tableeditor">
<tbody>
<tr>
<td>Name</td>
<td colspan="2">TC-001 Students option in Main menu&nbsp;</td>
</tr>
<tr>
<td>Pre-condition</td>
<td colspan="2">- Be logged in as Administrator<br />- Main Menu is accessible</td>
</tr>
<tr>
<td>Step</td>
<td>Action</td>
<td>Expected result</td>
</tr>
<tr>
<td>1</td>
<td>&nbsp;Navigate to the main menu</td>
<td>- &ldquo;Students&rdquo; option is visible</td>
</tr>
<tr>
<td>2</td>
<td>Click "Students" option</td>
<td>- Redirects to <span class="s1">Students screen</span> and shows table of students<br />- Table Should contain the colums DNI, Name, Surname<br />- Students list should be sorted by DNI<br />- Each Student row should have a pecil icon for user edition&nbsp;<br />- The pagination bar should be visible<br />- The 'Add Student' button should be visible at top of screen<br /><br /></td>
</tr>
</tbody>
</table>
<table class="source-tableeditor">
<tbody>
<tr>
<td>Name</td>
<td colspan="2">TC-002 Create a Student</td>
</tr>
<tr>
<td>Pre-condition</td>
<td colspan="2">- Be logged in as Administrator<br />- Administrator is on Students Screen</td>
</tr>
<tr>
<td>Step</td>
<td>Action</td>
<td>Expected result</td>
</tr>
<tr>
<td>1</td>
<td>Click "Add a new Student" link</td>
<td>The form to create a new Student is displayed with the next elements (*: mandatory)<br />- DNI* field<br />- Name* field<br />- Surname* field<br />- Date of Birth* field<br />- Phone* field<br />- "Save" button</td>
</tr>
<tr>
<td>2</td>
<td>Fill mandatory fields with correct data</td>
<td>It is able to save new user</td>
</tr>
<tr>
<td>3</td>
<td>Click "Save" button</td>
<td>- The Student is created<br />- message appears confirming the operation</td>
</tr>
</tbody>
</table>
<table class="source-tableeditor">
<tbody>
<tr>
<td>Name</td>
<td colspan="2">TC-003 Try to Create Student with invalid data</td>
</tr>
<tr>
<td>Pre-condition</td>
<td colspan="2">- Be logged in as Administrator<br />- Administrator is on Students Screen</td>
</tr>
<tr>
<td>Step</td>
<td>Action</td>
<td>Expected result</td>
</tr>
<tr>
<td>1</td>
<td>Click "Add a new Student" link</td>
<td>The form to create a new Student is displayed with the next elements (*: mandatory)<br />- DNI* field<br />- Name* field<br />- Surname* field<br />- Date of Birth* field<br />- Phone* field<br />- "Save" button</td>
</tr>
<tr>
<td>2</td>
<td>Fill mandatory fields with invalid &lt;example&gt;</td>
<td>It is not able to save new user</td>
</tr>
</tbody>
</table>
<table class="source-tableeditor">
<thead>
<tr>
<th>#</th>
<th>DNI</th>
<th>Name</th>
<th>Surname</th>
<th>Date of Birth</th>
<th>Phone</th>
<th>Expected Validation Error</th>
</tr>
</thead>
<tbody>
<tr>
<td>1</td>
<td></td>
<td>Juan</td>
<td>P&eacute;rez</td>
<td>2000-01-01</td>
<td>123456789</td>
<td>DNI is required</td>
</tr>
<tr>
<td>2</td>
<td>ABC123</td>
<td>Juan</td>
<td>P&eacute;rez</td>
<td>2000-01-01</td>
<td>123456789</td>
<td>DNI must be numeric</td>
</tr>
<tr>
<td>3</td>
<td>12345678</td>
<td></td>
<td>P&eacute;rez</td>
<td>2000-01-01</td>
<td>123456789</td>
<td>Name is required</td>
</tr>
<tr>
<td>4</td>
<td>12345678</td>
<td>Juan</td>
<td>P&eacute;rez</td>
<td>2030-01-01</td>
<td>123456789</td>
<td>Date of Birth cannot be in the future</td>
</tr>
</tbody>
</table>
<br />
<table class="source-tableeditor">
<tbody>
<tr>
<td>Name</td>
<td colspan="2">TC-004 Edit a Student</td>
</tr>
<tr>
<td>Pre-condition</td>
<td colspan="2">- Be logged in as Administrator<br />- Administrator is on Students Screen<br />- One student exist in database</td>
</tr>
<tr>
<td>Step</td>
<td>Action</td>
<td>Expected result</td>
</tr>
<tr>
<td>1</td>
<td>Click "Pencil" icon of student row in Students table</td>
<td>The form to Edit Student is displayed with Student data fullfilled</td>
</tr>
<tr>
<td>2</td>
<td>Set data form with &lt;example&gt;</td>
<td>It is able to save new user</td>
</tr>
<tr>
<td>3</td>
<td>Click "Save" button</td>
<td>- The Student is updated<br />- message appears confirming the operation</td>
</tr>
</tbody>
</table>
<table class="source-tableeditor">
<thead>
<tr>
<th>#</th>
<th>DNI</th>
<th>Name</th>
<th>Surname</th>
<th>Date of Birth</th>
<th>Phone</th>
</tr>
</thead>
<tbody>
<tr>
<td>1</td>
<td>12345678</td>
<td>Mar&iacute;a</td>
<td>L&oacute;pez</td>
<td>1995-04-12</td>
<td>1112345678</td>
</tr>
<tr>
<td>2</td>
<td>23456789</td>
<td>Carlos</td>
<td>G&oacute;mez</td>
<td>1990-11-30</td>
<td>1123456789</td>
</tr>
<tr>
<td>3</td>
<td>34567890</td>
<td>Luc&iacute;a</td>
<td>P&eacute;rez</td>
<td>2001-06-25</td>
<td>1134567890</td>
</tr>
<tr>
<td>4</td>
<td>45678901</td>
<td>Juli&aacute;n</td>
<td>Mart&iacute;nez</td>
<td>1998-09-08</td>
<td>1145678901</td>
</tr>
</tbody>
</table>
<br />
<table class="source-tableeditor">
<tbody>
<tr>
<td>Name</td>
<td colspan="2">TC-005 Try to Update Student with invalid data</td>
</tr>
<tr>
<td>Pre-condition</td>
<td colspan="2">- Be logged in as Administrator<br />- Administrator is on Students Screen<br />- One student exist in database</td>
</tr>
<tr>
<td>Step</td>
<td>Action</td>
<td>Expected result</td>
</tr>
<tr>
<td>1</td>
<td>Click "Pencil" icon of student row in Students table</td>
<td>The form to Edit Student is displayed with Student data fullfilled</td>
</tr>
<tr>
<td>2</td>
<td>Set data form with invalid &lt;example&gt;</td>
<td>It is not able to update user</td>
</tr>
</tbody>
</table>
<table class="source-tableeditor">
<thead>
<tr>
<th>#</th>
<th>DNI</th>
<th>Name</th>
<th>Surname</th>
<th>Date of Birth</th>
<th>Phone</th>
<th>Expected Error</th>
</tr>
</thead>
<tbody>
<tr>
<td>1</td>
<td></td>
<td>Laura</td>
<td>Fern&aacute;ndez</td>
<td>1995-02-20</td>
<td>1122334455</td>
<td>DNI is required</td>
</tr>
<tr>
<td>2</td>
<td>ABC123</td>
<td>Marcos</td>
<td>Garc&iacute;a</td>
<td>1993-07-15</td>
<td>1144556677</td>
<td>DNI must be numeric</td>
</tr>
<tr>
<td>3</td>
<td>34567890</td>
<td></td>
<td>Rodr&iacute;guez</td>
<td>2000-03-05</td>
<td>1155667788</td>
<td>Name is required</td>
</tr>
<tr>
<td>4</td>
<td>45678901</td>
<td>Elena</td>
<td>P&eacute;rez</td>
<td>2035-01-01</td>
<td>1177889900</td>
<td>Date of Birth cannot be in the future</td>
</tr>
<tr>
<td>5</td>
<td>56789012</td>
<td>Jorge</td>
<td>Su&aacute;rez</td>
<td>1991-11-11</td>
<td>11ABCD890</td>
<td>Phone must be numeric</td>
</tr>
</tbody>
</table>

## Exercise 4 - Integration Test creation

### [Tests]("AgileTest.Tests/StudentTests.cs")

## Exercise 5

<table class="source-tableeditor">
<tbody>
<tr>
<td>US-001</td>
<td colspan="2">View list of students</td>
</tr>
<tr>
<td colspan="3"><span class="s1">As a</span>n Administrator<br /><span class="s1">I want</span> to see a paginated list of all existing students<br /><span class="s1">So that</span> I can quickly review their basic information</td>
</tr>
<tr>
<td colspan="3">Acceptance Criteria</td>
</tr>
<tr>
<td colspan="3"><span class="s1">- A table should be displayed showing: DNI, First Name, and Last Name.<br />- The list should be ordered by DNI in ascending order.<br />- Pagination should be included.<br />- Each row should include an edit button (pencil icon). </span></td>
</tr>
</tbody>
</table>
<br />
<table class="source-tableeditor">
<tbody>
<tr>
<td>US-002</td>
<td colspan="2">Create student</td>
</tr>
<tr>
<td colspan="3"><span class="s1">As a</span>n Administrator<br /><span class="s1">I want to access a form to enter a new student&rsquo;s details<br />So that I can register them in the database</span></td>
</tr>
<tr>
<td colspan="3">Acceptance Criteria</td>
</tr>
<tr>
<td colspan="3"><span class="s1">- The form should include required fields: DNI, First Name, Last Name, Date of Birth, and Phone.<br />- All fields must be validated before saving.<br />- On successful save, the system should redirect to the student list and show the new student. </span></td>
</tr>
</tbody>
</table>
<br />
<table class="source-tableeditor">
<tbody>
<tr>
<td>US-003</td>
<td colspan="2">Edit student</td>
</tr>
<tr>
<td colspan="3"><span class="s1">As a</span>n Administrator<br /><span class="s1">I want</span> to edit the details of a previously registered student<br /><span class="s1">So that</span> I can keep their information up to date</td>
</tr>
<tr>
<td colspan="3">Acceptance Criteria</td>
</tr>
<tr>
<td colspan="3"><span class="s1">- Clicking the edit button in the list should open the form with pre-filled student data.<br />- All form validations should apply as in the creation flow.<br />- After saving, the system should return to the list and reflect the changes. </span></td>
</tr>
</tbody>
</table>
<br />
<table class="source-tableeditor">
<tbody>
<tr>
<td>US-004</td>
<td colspan="2"><span class="s1">Validate student form</span></td>
</tr>
<tr>
<td colspan="3"><span class="s1">As a</span>n Administrator<br /><span class="s1">I want</span> to receive clear error messages when invalid data is entered<br /><span class="s1">So that</span> I can easily correct issues and complete the form</td>
</tr>
<tr>
<td colspan="3">Acceptance Criteria</td>
</tr>
<tr>
<td colspan="3"><span class="s1">- Required fields should show an error if left empty.<br />- Invalid formats (e.g., letters in DNI) must prevent form submission and show appropriate error messages.<br />- Date of birth cannot be in the future. </span></td>
</tr>
</tbody>
</table>

## Exercise 6 - Automated tests Plan creation

### [Acceptance Tests]("./AgileTest.AcceptanceTests")
