package com.example.demo.entities;

import jakarta.persistence.*;

@Entity
@Table(name = "roles")
public class Roles {
    
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int rId;
    
    @Column(name = "rname", nullable = false)
    private String rname;

    // Getters and Setters
}

