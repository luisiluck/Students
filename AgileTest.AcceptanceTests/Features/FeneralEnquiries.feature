Feature: Contact-us

Simple calculator for adding two numbers

Scenario: General Enquiries Form
	Given the user is in "GeneralEnquiriesPage"
	When the "General Enquiries" form is filled out with...
	| FirstName | LastName | JobTitle   | Email     | Phone     | Company | Message          |
	| luis      | portillo | programmer | luis@p.co | 900806030 | abc.dot | QA Engineer Test |
 	And the "SendButton" is clicked
 	Then a "Thanks for submitting the form" text should be displayed
 