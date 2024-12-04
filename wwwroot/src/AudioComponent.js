window.toggleAudioPlayback = (isPlaying) => {
    const audioElement = document.getElementById("background-audio");
    if (!audioElement) {
        console.error("Audio element not found!");
        return;
    }
    if (isPlaying) {
        audioElement.pause();
    } else {
        audioElement.play();
    }
};