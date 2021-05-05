@Regression
@Send Email
Feature: Send Email
	The ability to send emails

Scenario: 1. Validate the ability to send emails
	Given I have 'ExistingUser' as a sender
	And I have 'ValidMail' email that will be sent
	When I open email form
	And I send email to myself
	Then I see received email in my inbox

Scenario Outline: 2. Validate the ability to send emails with invalid email
	Given I have 'ExistingUser' as a sender
	And I have 'ValidMail' email that will be sent
	When I open email form
	And I send mail with <InvalidAddress> invalid email address
	Then I see <ErrorMessage> response

	Examples: 
		| TestId   | InvalidAddress     | ErrorMessage                                            |
		| string   | InvalidUserAddress | Помилка: поштова скринька отримувача не існує           |
		| specChar | @#%^wewe!""&*()№\/ | Синтаксична помилка в параметрах або аргументах адреси. |
		| maxValue | 99999999999999999  | Помилка: поштова скринька отримувача не існує           |
		| minValue | -999999            | Помилка: поштова скринька отримувача не існує           |
		| zero     | 0                  | Помилка в параметрах або аргументах листа. (100503)     |