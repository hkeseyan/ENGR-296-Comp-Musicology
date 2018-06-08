setwd("E:/DATA/CSV/wdcompressed") # set working directory to location of compressed files
songnames <- list.files(pattern="*.csv") # retrieve song names from the working directory
#songnames <- songnames[1:50] ####
length(songnames) # check number of songs loaded
songs <- list()
for (i in 1:length(songnames)) songs[[i]] <- read.csv(songnames[i],header = T) # load every song and assign the song name to the name of the data set
names(songs) <- songnames
setwd("E:/DATA/CSV/tmnn") # set working directory to location where files will write
ticks <- sapply(songs,function(x){max(x[,2])}) # Retrieve largest time value in ticks for each song in list
tmax <- max(unlist(ticks)) # largest time value in entire list
tmax
#series <- list()
#require(gpuR)
#series <- list()

for (i in 1:length(songs)) {
  x <- songs[[i]]  # each song
  notes <- x[,1]  # note values ####
  times <- x[,2] # times of each note ####
  s <- rep(mean(notes), tmax) # time series of notes
  #s <- rep(0, tmax)
  for (t in times) {
    s[t] <- mean(notes[times==t]) # for every value of t where count>1, average the notes
  }
  #series[[i]] <- s
  write.csv(s, file = paste0(names(songs[i]), ".csv"), row.names = FALSE)
}
