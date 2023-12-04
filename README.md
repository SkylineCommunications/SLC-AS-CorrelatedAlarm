# Sample Correlated Alarm Information
This is a sample script to parse the information from a correlated alarm and show a JSON representation of an internal
class that represents the received alarm information.

Although the purpose is to demonstrate how to parse the correlated alarm information
(as described [here](https://docs.dataminer.services/user-guide/Advanced_Modules/Automation_module/FAQ/How_do_I_parse_Correlation_Alarm_Info_data.html))
The script uses the [Newtonsoft](https://www.newtonsoft.com/json) library to print the contents in the information console,
and therefore, it must be installed either by push from DIS or by creating and installing a package. 