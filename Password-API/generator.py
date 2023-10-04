import requests

while True:
    again = input("Do you want to generate a password? (y/n): ")
    if again == "y":
        length = input("Enter your password length: ")
        try:
            int(length)

        except:
            print("Please enter a number!")

        try:
            response = requests.get(f'http://localhost:5013/{length}')
            print(response.text)

        except:
            print("An error occured!")
        
    elif again == "n":
        break

    else:
        print("Please enter y or n")
