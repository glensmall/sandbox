package main

import (
	"fmt"
	"net/http"
)

// - Location of my handler functions

// home
func homeView(w http.ResponseWriter, r *http.Request) {

	w.WriteHeader(http.StatusOK)
	w.Header().Set("Content-Type", "text/plain; charset=utf-8")
	fmt.Fprintln(w, "This is the default handler for the homeView controller")
}

func main() {

	fmt.Println("Starting webServer......")

	http.HandleFunc("/", homeView)

	http.ListenAndServe(":8080", nil)

}
