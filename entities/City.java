package com.example.demo.entities;

import jakarta.persistence.*;

@Entity
@Table(name = "city")
public class City {
    
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int cId;
    
    @Column(name = "cname", nullable = false)
    private String cname;

    // Getters and Setters
}

