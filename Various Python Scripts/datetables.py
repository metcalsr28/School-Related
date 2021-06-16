if __name__ == "__main__":
    monthlist = ["JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC"]
    outstring = ""
    for x in range(95,99):
        for member in monthlist:
            outstring += member + x + "," + "\n"
    
    for x in range(1):
        for member in monthlist:
            outstring += member + x + "," + "\n"
        
    print(outstring)