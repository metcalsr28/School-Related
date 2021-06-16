import numpy as np
import math

if __name__ == "__main__":
    # Step 1
    rawUniformDataChunk = np.random.uniform(high=80, size=(50, 4))
    for x in range(20):
        rawUniformDataChunk[np.random.randint(50), np.random.randint(4)] = np.nan
    
    print(rawUniformDataChunk)
    print("*************************")

    total = 0
    countOfNotNan = 0
    for y in range(50):
        for x in range(4):
            if not math.isnan(rawUniformDataChunk[y][x]):
                total += rawUniformDataChunk[y][x]
                countOfNotNan += 1
    
    print("mean: " + str(total / countOfNotNan))


    # Step 2 
    input("WAITING FOR KEY PRESS TO EXPECT SECOND HALF")
    import impyute as impy
    rawUniformDataChunk = impy.mean(rawUniformDataChunk)
    print(rawUniformDataChunk)
    print("mean: " + str(rawUniformDataChunk.mean()))
