import pyttsx3

class TextToSpeachEngine(object):

    def __init__(self):
        self.engine = pyttsx3.init()

    def Speak(self, text):
        self.engine.say(text)
        self.engine.runAndWait()


if __name__ == "__main__":

    tts = TextToSpeachEngine()

    tts.Speak(input("Enter the text you want spoken: "))

