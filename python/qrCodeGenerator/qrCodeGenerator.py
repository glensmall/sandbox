import os
import pyqrcode
import png


class QRGenerator(object):

    def __init__(self, text):
        self.qr_image = self.qr_generator(text)

    @staticmethod
    def qr_generator(text):
        qr_code = pyqrcode.create(text)
        file_name = "QRCode"
        save_path = os.path.join(os.path.expanduser('~'), 'Downloads')
        name = f"{save_path}\\{file_name}.png"
        qr_code.png(name, scale=10)

        print(f"QR Code saved to {name}")


if __name__ == "__main__":
    QRGenerator(input("Enter the text to make the QR Code for: "))