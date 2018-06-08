setwd("E:/DATA/CSV/wd") # set working directory to location of csv files
songnames = list.files(pattern="*.csv") # retrieve song names from the working directory
length(songnames) # check number of songs loaded
object.size(songnames) # check size of the list on disk
#songnames = songnames[1:30] ### limit this for easy running
length(songnames) # check number of songs loaded
object.size(songnames) # check size of the list on disk
#for (i in 1:length(songnames)) assign(songnames[i], read.csv(songnames[i])) # load every song and assign the song name to the name of the data set
songs <- list() ### is list the best way to group the matricies?
for (i in 1:length(songnames)) songs[[i]] <- read.csv(songnames[i]) # load every song and assign the song name to the name of the data set
#summary(songs)
#head(songs)
object.size(songs)
names(songs) <- songnames

### TODO: separate tracks into new files?

songscompressed <- lapply(songs, function(x){x[x[,2]=="Note On",c(5,7)]})
object.size(songs)
object.size(songscompressed)

setwd("E:/DATA/CSV/wdcompressed") # set working directory to location of csv files
lapply(1:length(songscompressed), function(i) write.csv(songscompressed[[i]], 
                                                file = paste0(names(songscompressed[i]), ".csv"),
                                                row.names = FALSE))

### Record how effective compression is


### feed into classifier (should we label dataset first? how?)