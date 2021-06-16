import csv

if __name__ == "__main__":
    # WRITING TEST
    import csv
    with open('Monster.csv', 'w', newline='') as csvfile:
        testWriter = csv.writer(csvfile, delimiter=',', quoting=csv.QUOTE_NONE)
        testWriter.writerow(["TestMonster1", 5, 23, 54, 123])
        testWriter.writerow(["TestMonster2", 4, 22, 44, 103])
        testWriter.writerow(["TestMonster3", 7, 63, 554, 373])
        testWriter.writerow(["TestMonster4", 2, 3, 25, 123])
        testWriter.writerow(["TestMonster5", 8, 23, 54, 123])
        testWriter.writerow(["TestMonster6", 25, 23322, 5234, 122133])
        testWriter.writerow(["TestMonster7", 15, 3453, 354, 14223])
        testWriter.writerow(["TestMonster8", 86, 23432, 52344, 124353])
    
    # READING TEST
    with open('Monster.csv', newline='') as f:
        testReader = csv.reader(f)
        for row in testReader:
            print(row)