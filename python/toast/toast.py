import os
from win10toast import ToastNotifier

def notification():

    os.chdir(os.path.dirname(os.path.realpath(__file__)))
    toast = ToastNotifier()
    title = "Test Notification"
    message = "This is a toast notification from Python"

    icon = "icon.ico"
    length = 10

    toast.show_toast(title, message, icon_path=icon, duration=length)



if __name__ == "__main__":
    notification()