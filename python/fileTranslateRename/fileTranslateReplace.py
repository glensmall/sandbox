import os
from google_trans_new import google_translator 

# root folder from where we will scan
rootDir = r"C:\Users\glens\Videos\Lucy Cat"
processedDir = r"C:\Users\glens\Videos\Lucy Cat en"

# create the translator object
# do this globally to save calling it over and over in the method
translator = google_translator() 

# entrypoint for us
if __name__ == "__main__":

    # walk the root path and get the filenames
    for root, dirs, files in os.walk(rootDir):
        
        # now iterate over the files
        for filename in files:
                      
            print(f'Working on [{filename}]\n')
            
            # translate the filename from german to english
            txt = translator.translate(filename, lang_tgt='en')
            
            newFilename = txt.replace('/', '.')

            print(f'Translated to [{newFilename}\n')
            
            # now move the file to a new location with the new name
            os.rename(os.path.join(rootDir, filename), os.path.join(processedDir, newFilename))
