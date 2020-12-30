package main

import (
	"fmt"
	"io/ioutil"
	"net/http"
)

func homeView(w http.ResponseWriter, r *http.Request) {

	w.WriteHeader(http.StatusOK)
	w.Header().Set("Content-Type", "text/html; charset=utf-8")

	// read the file
	data, err := ioutil.ReadFile("index.html")

	if err != nil {
		fmt.Println("Error Reading the html file", err)
	}

	fmt.Fprintln(w, data)
}

func main() {

	fmt.Println("Starting webServer......")

	http.HandleFunc("/", homeView)

	http.ListenAndServe(":8080", nil)
}
